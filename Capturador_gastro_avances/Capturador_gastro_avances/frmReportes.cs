using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Capturador_gastro_avances
{
    public partial class frmReportes : Form
    {

        protected bool validData;
        string path;
        protected Image image;
        protected Thread getImageThread;
        PictureBox[] cajas;
        string[] imagenes;
        private int numero_cajas;
        public frmReportes(int cajas)
        {
            numero_cajas = cajas;
            InitializeComponent();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            dibujar_Cajas(numero_cajas);
        }

        private void dibujar_Cajas(int numero)
        {
            cajas = new PictureBox[numero];
            imagenes = new string[numero];
            int tama = 0;
            int x = 0;
            int y = 0;
            int max = 0;
            int m = 0;
            int n = 0;
            int offset_x = 0;
            int offset_y = 0;
            int distancia = 0;
            if(numero==6)
            {
                tama = 135;
                offset_x = 190;
                offset_y = 190;
                distancia = 140;
                x = offset_x + n * distancia;
                y = offset_y + m * distancia;
                max = 3;
            }else if(numero==9)
            {
                tama = 130;
                offset_x = 190;
                offset_y = 140;
                distancia = 135;
                x = offset_x + n * distancia;
                y = offset_y + m * distancia;
                max = 3;
            }
            else if (numero == 12)
            {
                tama = 125;
                offset_x = 140;
                offset_y = 150;
                distancia = 130;
                x = offset_x + n * distancia;
                y = offset_y + m * distancia;
                max = 4;
            }
            for (int i = 0; i < numero; i++)
            {
                x = offset_x + n * distancia;
                y = offset_y + m * distancia;
                System.Console.WriteLine("ciclo numero: " + i.ToString());
                cajas[i] = new PictureBox();
                cajas[i].Size = new Size(tama, tama);
                cajas[i].Location = new Point(x, y);
                cajas[i].DragEnter += new DragEventHandler(drag_enter_Pic);
                cajas[i].DragDrop += new DragEventHandler(drag_drop_Pic);
                cajas[i].MouseClick += new MouseEventHandler(click_Caja);
                cajas[i].SizeMode = PictureBoxSizeMode.Zoom;
                cajas[i].Paint += new PaintEventHandler(pintarCaja);
                ((Control)cajas[i]).AllowDrop = true;
                cajas[i].BackColor = Color.White;
                cajas[i].Visible = true;
                cajas[i].Name = i.ToString();
                pnlMain.Controls.Add(cajas[i]);
                n++;
                if (n==max)
                {
                    n = 0;
                    m++;
                }
            }
        }

        private void drag_drop_Pic(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                var picture = sender as PictureBox;
                picture.Image = image;
                imagenes[int.Parse(picture.Name)] = path;
                //Console.WriteLine("ruta del archivo: " + path);

            }
        }

        private void click_Caja(object sender, MouseEventArgs e)
        {
            var picture = sender as PictureBox;
            if(picture.Image!= null)
            {
                if (Color.Equals(picture.Tag, Color.Red))
                    picture.Tag = Color.Transparent;
                else
                    picture.Tag = Color.Red;
                picture.Refresh();
            }

        }

        private void pintarCaja(object sender, PaintEventArgs e)
        {
            var picture = sender as PictureBox;
            if(picture.Tag!=null)
            ControlPaint.DrawBorder(e.Graphics, picture.ClientRectangle, (Color)picture.Tag, ButtonBorderStyle.Solid);

        }

        private void drag_enter_Pic(object sender, DragEventArgs e)
        {
            string filename;
            
            //System.Console.WriteLine(filename);

            validData = GetFilename(out filename, e);            
            if (validData)
            {                
                path = filename;               
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }


        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        System.Console.WriteLine(filename);
                        string ext = System.IO.Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp") || (ext == ".jpeg"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }


        protected void LoadImage()
        {
            image = new Bitmap(path);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pic in cajas)
            {
                if(pic.Image!= null && Color.Equals(pic.Tag,Color.Red))
                {
                    pic.Image = null;
                    pic.Tag = Color.Transparent;
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            bool lleno = true;
            foreach(PictureBox pic in cajas)
            {
                if(pic.Image == null)
                {
                    lleno = false;
                }
            }
            if(lleno)
            {
                creador_Reporte repo = new creador_Reporte();
                repo.crearDocumento_plantilla(imagenes, numero_cajas);
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //private void btnFin_DragDrop(object sender, DragEventArgs e)
        //{
        //    if (validData)
        //    {
        //        while (getImageThread.IsAlive)
        //        {
        //            Application.DoEvents();
        //            Thread.Sleep(0);
        //        }
        //        pictureBox1.Image = image;
        //    }

        //}



        //private void btnFin_DragEnter(object sender, DragEventArgs e)
        //{
        //    string filename;
        //    validData = GetFilename(out filename, e);
        //    if (validData)
        //    {
        //        path = filename;
        //        getImageThread = new Thread(new ThreadStart(LoadImage));
        //        getImageThread.Start();
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //        e.Effect = DragDropEffects.None;

        //}

    }
}
