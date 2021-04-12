using Accord.Video.FFMPEG;
using AForge.Controls;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using Capturador_gastro_avances.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturador_gastro_avances
{
    public partial class frmSesion : Form
    {
        int contador_imagenes = 0;
        int contador_video = 0;
        FilterInfoCollection videoDevices = null;
        string carpeta = Settings.Default.folder_path;

        string path = string.Empty;
        string fecha = string.Empty;
        string folder = string.Empty;
        string carpeta_actual = string.Empty;
        string nombre_paciente = string.Empty;

        private int FrameRate = 25;
        double timeBetweenFramesInSeconds = 0;
        private BrightnessCorrection bc = new BrightnessCorrection(0);
        private ContrastCorrection cc = new ContrastCorrection(0);
        private SaturationCorrection sc = new SaturationCorrection(0);

        private bool grabando,inputs = false;

        VideoCaptureDevice devi = null;

        //private IVideoSource video_source;

        DateTime firstTimeF = default;

        FiltersSequence filter = new FiltersSequence();

        long currentTick = 0;
        Stopwatch stopwatch = new Stopwatch();

        int grabacion_x = 0;
        int grabacion_y = 0;
        int cantidad_imagenes = 0;
        bool existe = false;

        private VideoFileWriter writer_Video;

        frmPrincipal insta = null;

        public long? StartTick { get; private set; }

        public frmSesion(string nombre, frmPrincipal insta)
        {
            this.insta = insta;
            nombre_paciente = nombre;
            folder = Settings.Default.folder_path;
            InitializeComponent();
        }

        // metodo para centrar el picturebox en el panel contenedor 

        private void centrarReproductor()
        {
            int pnl_x = pnlVideo.Size.Width;
            int pnl_y = pnlVideo.Size.Height;

            int offset_x = pictureBox1.Width;
            int offset_y = pictureBox1.Height;
            int x_location = (pnl_x / 2) - (offset_x / 2);
            int y_location = (pnl_y / 2) - (offset_y / 2);
            pictureBox1.Location = new Point(x_location, y_location);
        }

        private void frmSesion_Load(object sender, EventArgs e)
        {
            centrarReproductor();
            centrar_Filtros();
            cargarFiltros();

            // descomentar linea de abajo para habilitar grabacion


            timeBetweenFramesInSeconds = 1.0 / FrameRate;
            btnGrabar.Enabled = false;
            btnDesconectar.Enabled = false;
            btnFinal.Enabled = false;

            //Console.WriteLine("que mierda pasa");


            
            

            buscar_Fuentesvideo();

            //Console.WriteLine(Settings.Default.dispositivo_defecto);
            //Console.WriteLine(Settings.Default.entrada_defecto);
            //Console.WriteLine(Settings.Default.resolucion_defecto);
            int n = 0;

            

            if (comboVideo.Items.Contains(Settings.Default.dispositivo_defecto))
            {
                n = comboVideo.Items.IndexOf(Settings.Default.dispositivo_defecto);
                comboVideo.SelectedIndex = n;
                VideoCaptureDevice devi = new VideoCaptureDevice(videoDevices[comboVideo.SelectedIndex].MonikerString);

                comboRes.Items.Clear();
                if (devi.VideoCapabilities.Length > 0)
                {
                    foreach (var cap in devi.VideoCapabilities)
                    {
                        comboRes.Items.Add(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                        //  Console.WriteLine(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                    }
                    comboRes.SelectedIndex = 0;
                }
                else
                {
                    comboRes.Items.Insert(0, "No Aplica");
                    comboRes.SelectedIndex = 0;
                    comboRes.Enabled = false;
                }

                comboInputs.Items.Clear();
                if (devi.AvailableCrossbarVideoInputs.Length <= 0)
                {
                    comboInputs.Items.Insert(0, "No Aplica");
                    comboInputs.SelectedIndex = 0;
                    comboInputs.Enabled = false;
                    inputs = false;
                }
                else
                {
                    foreach (var cap in devi.AvailableCrossbarVideoInputs)
                    {
                        comboInputs.Items.Add(cap.Type.ToString());
                    }
                    inputs = true;
                    comboInputs.SelectedIndex = 0;
                    comboInputs.Enabled = true;
                }
                //comboBox2.Enabled = true;
                
            }
                
            
            if (comboVideo.Items.Contains(Settings.Default.dispositivo_defecto) && comboInputs.Items.Contains(Settings.Default.entrada_defecto) && comboRes.Items.Contains(Settings.Default.resolucion_defecto))
            {
                Console.WriteLine("existe");
                existe = true;
                comboVideo.SelectedIndex = comboVideo.Items.IndexOf(Settings.Default.dispositivo_defecto);
                comboInputs.SelectedIndex = comboInputs.Items.IndexOf(Settings.Default.entrada_defecto);
                comboRes.SelectedIndex = comboRes.Items.IndexOf(Settings.Default.resolucion_defecto);
            }
            Console.WriteLine(Settings.Default.auto);

            if (Settings.Default.auto && existe)
            {
                Thread.Sleep(700);
                conectar_Video();
            }
            


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar_Fuentesvideo();
        }

        private void buscar_Fuentesvideo()
        {
            // buscar fuentes de video y mostrar resoluciones disponibles
            try
            {
                comboVideo.Items.Clear();                
                comboInputs.Items.Clear();
                comboRes.Items.Clear();
                // enumerar dispositivos de video
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                
                if (videoDevices.Count > 0)
                {
                    
                    foreach (FilterInfo device in videoDevices)
                    {
                        comboVideo.Items.Add(device.Name);
                    }

                    try
                    {
                        if (comboVideo.Items.Count > 0)
                        {
                            comboVideo.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error: " + ex.Message);
                    }

                    VideoCaptureDevice devi = new VideoCaptureDevice(videoDevices[comboVideo.SelectedIndex].MonikerString);

                    comboRes.Items.Clear();
                    if (devi.VideoCapabilities.Length > 0)
                    {
                        foreach (var cap in devi.VideoCapabilities)
                        {
                            comboRes.Items.Add(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                            //  Console.WriteLine(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                        }
                        comboRes.SelectedIndex = 0;
                        comboRes.Enabled = true;
                    }
                    else
                    {
                        comboRes.Items.Insert(0,"No Aplica");
                        comboRes.SelectedIndex = 0;
                        comboRes.Enabled = false;
                    }

                    comboInputs.Items.Clear();
                    if (devi.AvailableCrossbarVideoInputs.Length > 0)
                    {
                        foreach (var cap in devi.AvailableCrossbarVideoInputs)
                        {
                            comboInputs.Items.Add(cap.Type.ToString());
                            //  Console.WriteLine(cap.Type.ToString());
                        }
                        comboInputs.SelectedIndex = 0;
                        comboInputs.Enabled = true;
                        inputs = true;
                    }
                    else
                    {
                        comboInputs.Items.Insert(0, "No Aplica");
                        comboInputs.SelectedIndex = 0;
                        comboInputs.Enabled = false;
                        inputs = false;
                    }
                    comboVideo.Enabled = true;
                    btnConectar.Enabled = true;
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("error: " + ex.Message);
                comboRes.Enabled = false;
                comboVideo.Enabled = false;
                btnConectar.Enabled = false;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectar_Video();
        }

        private void conectar_Video()
        {
            try
            {
                if (!string.IsNullOrEmpty(comboVideo.Text))
                {

                    // configurar la resolucion seleccionada para el dispositivo
                    devi = new VideoCaptureDevice(videoDevices[comboVideo.SelectedIndex].MonikerString);
                    try
                    {
                        devi.VideoResolution = devi.VideoCapabilities[comboRes.SelectedIndex];
                    }
                    catch (InvalidCastException ex)
                    {
                        Console.WriteLine("error en resolucion: " + ex.Message);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("error:" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error: " + ex.Message);
                    }

                    // definir el tamaño de el picturebox para mantener la relación de aspecto dentro del espacio disponible en el panel

                    // Console.WriteLine(comboVideo.SelectedIndex.ToString() + " res: " + comboRes.SelectedIndex.ToString());

                    if(devi.VideoResolution != null)
                    {
                        int x_size = grabacion_x = devi.VideoResolution.FrameSize.Width;
                        int y_size = grabacion_y = devi.VideoResolution.FrameSize.Height;

                        //int framerate = devi.VideoCapabilities[0].AverageFrameRate;
                        //Console.WriteLine(framerate.ToString());

                        int bordes = 30;  // espacio en pixeles entre el picturebox y el panel contenedor

                        int pnl_x = pnlVideo.Width - bordes;
                        int pnl_y = pnlVideo.Height - bordes;
                        Size tama = new Size(x_size, y_size);

                        // cambiar el tamaño del picturebox 

                        Size nuevo = redimension_Control(tama, pnl_x, pnl_y, false);
                        redimension_Video(nuevo);
                    }    

                    

                    // centrar el picturebox en el panel contenedor
                    centrarReproductor();

                    btnConectar.Enabled = false;
                    btnBuscar.Enabled = false;
                    comboVideo.Enabled = false;
                    comboRes.Enabled = false;
                    comboInputs.Enabled = false;

                    if (inputs)
                    {
                        devi.CrossbarVideoInput = devi.AvailableCrossbarVideoInputs[comboInputs.SelectedIndex];
                        Settings.Default.entrada_defecto = comboInputs.Text;
                    }
                    else
                    {
                        Settings.Default.entrada_defecto = "No Aplica";
                    }

                    devi.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                    devi.Start();

                    // detener el hilo principal antes de habilitar los botones de desconexion y grabar hasta que el video se esté mostrando
                    // comprobación de video antes de habilitar? 

                    int contador = 0;
                    while (devi.IsRunning && pictureBox1.Image == null)
                    {
                        //Console.WriteLine("conectando");
                        contador++;
                        Thread.Sleep(100);
                        if (contador == 50)
                            break;
                    }

                    // guardar el último dispositivo utilizado como la conexión por defecto

                    Settings.Default.dispositivo_defecto = comboVideo.Text;                    
                    Settings.Default.resolucion_defecto = comboRes.Text;

                    Settings.Default.Save();

                    Thread.Sleep(1300);


                    if (devi.IsRunning && pictureBox1.Image != null)
                        Console.WriteLine("reproduciendo");

                    btnGrabar.Enabled = true;
                    btnDesconectar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
        }


        private async void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {   
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                /// System.Console.WriteLine("bitmap: " + bitmap.ToString());
                if (bitmap != null)
                    await ProcesarImagen(bitmap);
                else
                    System.Console.WriteLine("no hay imagen");
                // usar tasks para procesar las imagenes de manera paralela y no perder fps en el video 
                //   pictureBox1.Image = newframe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " +  ex.Message);
            }
        }

        private void cambiarImagen(Bitmap nueva)
        {            
            try
            {
                Bitmap imVideo = (Bitmap)nueva.Clone();
                pictureBox1.Image = nueva;
                if (grabando)
                {
                    if (currentTick != 0)
                    {
                        double elapsedTimeInSeconds = stopwatch.ElapsedTicks / (double)Stopwatch.Frequency;
                        Console.WriteLine("segundos: " + elapsedTimeInSeconds.ToString());
                        if (elapsedTimeInSeconds >= timeBetweenFramesInSeconds)
                        {
                            Console.WriteLine("escribiendo fram");
                            currentTick = DateTime.Now.Ticks;
                            var frameOffset = new TimeSpan(currentTick - StartTick.Value);
                            writer_Video.WriteVideoFrame(imVideo, frameOffset);
                            stopwatch.Restart();
                        }
                        // Console.WriteLine(truncatedtime);
                    }
                    else
                    {
                        Console.WriteLine("en el else ");
                        if (writer_Video != null)
                            writer_Video.WriteVideoFrame(imVideo);
                        currentTick = DateTime.Now.Ticks;
                        StartTick = currentTick;
                        stopwatch.Start();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
            }
        }

        private async Task ProcesarImagen(Bitmap original)
        {
            var cTask = Task.Run(() => regresarImagen(original));
            var imagen = await cTask;
            if(imagen != null)
            {
                var dTask = Task.Run(() => cambiarImagen(imagen));
                dTask.Wait();
            }            
            
        }

        private Bitmap regresarImagen(Bitmap original)
        {
            try
            {
                Bitmap newframe = filter.Apply(original);
                return newframe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("excepcion en filtros: " + ex.Message);
                return null;
            }
        }

        // funcion para actualizar el tamaño del picturebox
        public void redimension_Video(Size nuevo)
        {
            pictureBox1.Size = nuevo;
        }

        // esta función determina el tamaño maximo que puede llegar a tener el picturebox manteniendo la relación de aspecto de la resolución original
        // el tamaño original de la imagen está dado por la resolución seleccionada del dispositivo de video, representada por "src"
        // las variables "maxWidth" y "maxHeight" son las dimensiones del contenedor, en este caso el panel que contiene el picturebox que muestra el video
        // menos la cantidad en pixeles de la variable "bordes" 

        public static Size redimension_Control(Size src, int maxWidth, int maxHeight, bool enlarge = false)
        {
            try
            {
                maxWidth = enlarge ? maxWidth : Math.Min(maxWidth, src.Width);
                maxHeight = enlarge ? maxHeight : Math.Min(maxHeight, src.Height);

                decimal rnd = Math.Min(maxWidth / (decimal)src.Width, maxHeight / (decimal)src.Height);
          //      Console.WriteLine("redimension correcta");
                return new Size((int)Math.Round(src.Width * rnd), (int)Math.Round(src.Height * rnd));
                
            }catch(Exception ex)
            {
                System.Console.WriteLine("falla en redimension" + ex.Message);
                return new Size();
            }            
        }

        // metodo para inicializar los filtros con un valor de "0" 
        private void cargarFiltros()
        {
            // añadir correciones a la secuencia de filtros
            filter.Add(bc);
            filter.Add(cc);
            filter.Add(sc);
        }

        // metodo para centrar los titulos y scrolls de los filtros de video
        private void centrar_Filtros()
        {
            int pnl_x = pnlFiltros.Size.Width;
            int pnl_y = pnlFiltros.Size.Height;
            int cantidad_filtros = 0;
            int total_y = 0;
            int lbl_y = 0;
            int espaciado = 25;

            foreach (var ctrl in pnlFiltros.ControlsInTabOrder())
            {
                if (ctrl is Label)
                {
                    total_y += ctrl.Height;
                }
                if (ctrl is SliderControl)
                {
                    cantidad_filtros += 1;
                    total_y += ctrl.Height;
                }
                total_y += espaciado;
            }

            cantidad_filtros = 0;

            foreach (var ctrl in pnlFiltros.ControlsInTabOrder())
            {
                if (ctrl is Label)
                {
                    lbl_y = ctrl.Height;
                    int offset_x = ctrl.Width;
                    int offset_y = ctrl.Height;
                    int x_location = (pnl_x / 2) - (offset_x / 2);
                    int y_location = (pnl_y / 2) - (total_y / 2) + (lbl_y + 23 + espaciado) * cantidad_filtros; // 23 es el tamaño de el slider
                    ctrl.Location = new Point(x_location, y_location);
                }
                if (ctrl is TrackBar)
                {
                    int offset_x = ctrl.Width;
                    int offset_y = ctrl.Height;
                    int x_location = (pnl_x / 2) - (offset_x / 2);
                    int y_location = (pnl_y / 2) - (total_y / 2) + lbl_y + (lbl_y + 23 + espaciado) * (cantidad_filtros); // 23 es el tamaño de el slider
                    ctrl.Location = new Point(x_location, y_location);
                    cantidad_filtros += 1;
                }
            }
        }

        private void trkBrillo_Scroll(object sender, EventArgs e)
        {
            int n = trkBrillo.Value;
            bc.AdjustValue = n;
        }

        private void trkContraste_Scroll(object sender, EventArgs e)
        {
            int n = trkContraste.Value;
            cc.Factor = n;
        }

        private void trkSaturacion_Scroll(object sender, EventArgs e)
        {
            int n = trkSaturacion.Value;
            float sat = (float)n / 100;
            sc.AdjustValue = sat;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            trkBrillo.Value = 0;
            trkContraste.Value = 0;
            trkSaturacion.Value = 0;
            bc.AdjustValue = 0;
            cc.Factor = 0;
            sc.AdjustValue = 0;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            devi.SignalToStop();
            Thread.Sleep(300);
            comboRes.Enabled = true;
            comboVideo.Enabled = true;
            comboInputs.Enabled = true;
            pictureBox1.Image = null;
            pictureBox1.Update();
            btnConectar.Enabled = true;
            btnGrabar.Enabled = false;
            btnBuscar.Enabled = true;
            // devi = null;
            // GC.Collect();
        }

        // metodo utilizado para crear un nuevo directorio al tomar una imagen en una nueva sesión o al grabar un video 
        private void crearDirectorio()
        {
            String anio = DateTime.Now.Year.ToString();
            String mes = DateTime.Now.Month.ToString();
            String dia = DateTime.Now.Day.ToString();
            String hora = DateTime.Now.Hour.ToString();
            String minuto = DateTime.Now.Minute.ToString();
            String path = folder + @"\" + nombre_paciente + "_" + anio + mes + dia + "_" + hora + "_" + minuto;
            fecha = anio + mes + dia;
            carpeta_actual = path;
            DirectoryInfo di = Directory.CreateDirectory(path);

            // capturar exepciones

          //  Console.WriteLine("Directorio creado");
        }

        // método para guardar la captura realizada
        private void Guardar_captura() 
        {
            try
            {
                if (!(devi == null))
                {
                    if (devi.IsRunning)
                    {
                        if (!folder.Equals("none"))
                        {
                            if (contador_imagenes == 0 && contador_video == 0)
                            {
                                crearDirectorio();
                            }

                           // Console.WriteLine("captura");

                            Bitmap capt = (Bitmap)pictureBox1.Image.Clone();

                            String cantidad = contador_imagenes.ToString();

                            capt.Save(carpeta_actual + @"\" + fecha + "_" + cantidad + "." + Properties.Settings.Default.Image_format);

                            // pictCaptura.Image = capt;
                            contador_imagenes += 1;
                            lblCantidad.Text = contador_imagenes.ToString();
                            if (!grabando)
                                btnFinal.Enabled = true;
                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine("error: " + ex.ToString());
            }
            catch (Exception e)
            {
                System.Console.WriteLine("error: " + e.ToString());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (contador_video == 0 && contador_imagenes == 0)
            {
                crearDirectorio();
            }
            grabar(carpeta_actual, grabacion_x, grabacion_y);
        }

        // función para guardar video, la variable "path" representa la ubicación a utilizar para guardar el archivo de video, "width" y "height" representan la
        // resolución del video en pixeles 

        private void grabar(string path, int width, int height)
        {
            try
            {
                if (!grabando)
                {
                    writer_Video = new VideoFileWriter();
                    string nombre = path + @"\" + "video_" + contador_video + ".mp4";
                    writer_Video.Open(nombre, width, height,25,VideoCodec.MPEG4);
                    grabando = true;
                    btnGrabar.IconColor = Color.FromArgb(115, 54, 65);
                    btnGrabar.Text = "Detener";
                    btnDesconectar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //btnModificar.Enabled = false;
                    btnFinal.Enabled = false;
                    btnCerrar.Enabled = false;
                    contador_video++;
                }
                else
                {
                    btnGrabar.IconColor = Color.FromArgb(232, 229, 238);
                    detenerGrabacion();
                    btnGrabar.Text = "Grabar";
                    btnDesconectar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnFinal.Enabled = true;
                    btnCerrar.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }

        }

        //// metodo para detener la grabación y guardar el video 

        private void detenerGrabacion()
        {
            currentTick = default;
            stopwatch.Stop();
            grabando = false;
            writer_Video.Close();
            writer_Video.Dispose();
        }

        // referencias y funcion para mover la ventana desde el panel superior

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Guardar_captura();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (devi != null)
            {
                if (devi.IsRunning)
                    devi.SignalToStop();
            }
            this.Close();
            insta.Show();
            this.Dispose();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (devi.IsRunning)
                    devi.SignalToStop();
                if (!String.IsNullOrEmpty(carpeta_actual))
                {
                    System.Diagnostics.Process.Start(carpeta_actual);
                    this.Close();
                    this.Dispose();
                    insta.Show();
                }
            }
            catch (Exception ex)
            {
                //The system cannot find the file specified...
                Console.WriteLine("error: " + ex.Message);
            }
        }

        private void frmSesion_Shown(object sender, EventArgs e)
        {
        
        }

        private void comboVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboRes.Items.Clear();
                comboInputs.Items.Clear();
                VideoCaptureDevice devi = new VideoCaptureDevice(videoDevices[comboVideo.SelectedIndex].MonikerString);
                
                if (devi.VideoCapabilities.Length > 0)
                {
                    foreach (var cap in devi.VideoCapabilities)
                    {
                        comboRes.Items.Add(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                        //  Console.WriteLine(cap.FrameSize.Width + "X" + cap.FrameSize.Height);
                    }
                    comboRes.SelectedIndex = 0;
                    comboRes.Enabled = true;
                }
                else
                {
                    comboRes.Items.Insert(0, "No Aplica");
                    comboRes.SelectedIndex = 0;
                    comboRes.Enabled = false;
                }
                

                
                if (devi.AvailableCrossbarVideoInputs.Length <= 0)
                {
                    comboInputs.Items.Insert(0, "No Aplica");
                    comboInputs.SelectedIndex = 0;
                    comboInputs.Enabled = false;
                    inputs = false;
                }
                else
                {
                    foreach (var cap in devi.AvailableCrossbarVideoInputs)
                    {
                        comboInputs.Items.Add(cap.Type.ToString());
                    }
                    inputs = true;
                    comboInputs.SelectedIndex = 0;
                    comboInputs.Enabled = true;
                }  
            }

            catch (Exception ex)
            {

            }
        }                        
    }
}
