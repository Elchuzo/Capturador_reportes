using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using Capturador_gastro_avances.Properties;
using System.IO;

namespace Capturador_gastro_avances
{
    class creador_Reporte
    {
        string tipo_letra = string.Empty;
        string nombre_paciente = string.Empty;
        string hospital = string.Empty;
        string medico_referente = string.Empty;
        string tipo_compra = string.Empty;
        string servicio = string.Empty;
        string sps = string.Empty;
        string sedacion = string.Empty;
        string procedimiento = string.Empty;

        int edad_paciente = 0;
        int numero_afiliacion = 0;

        _Application oWord;
        _Document oDoc;
        object oMissing = Missing.Value;

        //object fileName = "C:\\temp.dot";
        object fileNameSaveAs = @"F:\Capturador_gastro_avances\documento.doc";
        object fileFormat = WdSaveFormat.wdFormatDocumentDefault;
        object saveChanges = WdSaveOptions.wdDoNotSaveChanges;

        public creador_Reporte()
        {

        }
        // METODO DE PRUEBA NO PONER ATENCION
        public void crearDocumento()
        {
            try
            {
                Word.Application winword = new Word.Application();
                //winword.ShowAnimation = false;
                winword.Visible = false;
                object missing = Missing.Value;
                Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                foreach (Section section in document.Sections)
                {
                    //Console.WriteLine(section.ToString());
                    //Get the header range and add the header details.  
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    Color c = Color.FromArgb(11, 163, 33);
                    headerRange.Font.Color = (WdColor)(c.R + 0x100 * c.G + 0x10000 * c.B);
                    headerRange.Font.Name = "arial narrow";
                    headerRange.Font.Size = 12;
                    headerRange.Font.Bold = 1;
                    headerRange.Text = "Urgencias Endoscópicas Gastroenterológicas S.A.";
                }

                //Save the document  
                object filename = @"F:\Proyecto Salazar\prueba1";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en creación de documento: " + ex.Message);
            }
        }




        public void crearDocumento_plantilla(string[] imagenes, int cantidad)
        {
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            object oTemplate = null;

            //object oTemplate = @"F:\Capturador_gastro_avances\Plantilla_reporte.docx";
            //object oBookMark = "paciente";
            //if (oDoc.Bookmarks.Exists("paciente"))
            //    oDoc.Bookmarks["paciente"].Range.Text = "nombre_paciente";
            //var doc = Resources.plantilla_6 as Document;

            String anio = DateTime.Now.Year.ToString();
            String mes = DateTime.Now.Month.ToString();
            String dia = DateTime.Now.Day.ToString();
            String hora = DateTime.Now.Hour.ToString();
            String minuto = DateTime.Now.Minute.ToString();
            string datos = mes + "_" + dia + "_" + hora + "_" + minuto;

            string folder = Properties.Settings.Default.folder_path;

            if(!Directory.Exists(folder))
            {
                return;
            }

            string directorio = folder +  @"\plantilla.docx";
            string directorio2 = folder + @"\" + datos + ".doc";

            fileNameSaveAs = directorio2;
            //System.Console.WriteLine(directorio);

            switch (cantidad)
            {
                case 6:
                    File.WriteAllBytes(directorio, Resources.plantilla_6);
                    break;
                case 9:
                    File.WriteAllBytes(directorio, Resources.plantilla_9);
                    break;                    
                case 12:
                    File.WriteAllBytes(directorio, Resources.plantilla_12);
                    break;
            }
            oTemplate = directorio;
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);
            for (int i = 0; i<imagenes.Length; i++)
            {
                int n = i + 1;
                string marcador = "pic" + n.ToString();
                object oBookMark = "pic" + n.ToString();
                if (oDoc.Bookmarks.Exists(marcador))
                    oDoc.Bookmarks[marcador].Select();
                string picPath = imagenes[i];
                var ima = oWord.Selection.InlineShapes.AddPicture(picPath, false, true);
                ima.Height = oWord.CentimetersToPoints(3f);
                ima.Width = oWord.CentimetersToPoints(4.5f);
            }

            oWord.ActiveDocument.Characters.Last.Select();
            oWord.Selection.Collapse();
            Range objRange = oWord.Selection.Range;
            objRange.Text = "DR. JAHIR QUIROA";
            objRange.Bold = 1;
            objRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //string marca = "nombre";
            //if (oDoc.Bookmarks.Exists(marca))
            //{
            //    Bookmark bookmark1 = oDoc.Bookmarks[marca];
            //    Range objRange = bookmark1.Range;
            //    objRange.Text = "DR. JAHIR QUIROA";
            //    objRange.Bold = 1;
            //    objRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //}


            //oWord.Visible = true;
            oDoc.SaveAs(ref fileNameSaveAs, ref fileFormat, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            // close the open document   CERRAR DOCUMENTO ABIERTO
           // oDoc.Close(ref saveChanges, ref oMissing, ref oMissing);
            // quit word        VOLVER A HABILITAR PARA CERRAR EL DOCUMENTO
            //oWord.Quit(ref saveChanges, ref oMissing, ref oMissing);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(oWord);
            //Marshal.FinalReleaseComObject(oTemplate);

        }


    }
}
