using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturador_gastro_avances
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Console.WriteLine("iniciando programma");
            ajustarBotones();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            System.Console.WriteLine(Properties.Resources.plantilla_6);

            //creador_Reporte repo = new creador_Reporte();
            //repo.crearDocumento_plantilla();

        }

        private void ajustarBotones()
        {
            int pnl_x = pnlMain.Size.Width;
            int pnl_y = pnlMain.Size.Height;
            int cantidad_botones = 0;
            int total_y = 0;

            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl is IconButton && ctrl.Visible)
                {
                    cantidad_botones += 1;
                    total_y += ctrl.Height;
                }
            }
            cantidad_botones = 0;

            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl is IconButton && ctrl.Visible)
                {
                    cantidad_botones += 1;
                    int offset_x = ctrl.Width;
                    int offset_y = ctrl.Height;
                    int x_location = (pnl_x / 2) - (offset_x / 2);
                    int y_location = (pnl_y / 2) + (total_y / 2) - ctrl.Height * cantidad_botones;
                    ctrl.Location = new Point(x_location, y_location);
                }
            }
            //btnCerrar.Location = new Point((frm_x / 2) - (offset_x / 2));
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            System.Environment.Exit(1);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // mover form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if(!Properties.Settings.Default.folder_path.Equals("none"))
            {
                this.Hide();
                frmDatos datos = new frmDatos(this);
                datos.Show();
            }
            
            //this.Dispose();

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjustes ajustes = new frmAjustes(this);
            ajustes.Show();
        }

        private void btnCapturas_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmCantidad cantidades = new frmCantidad();
            cantidades.Show();
        }
    }
}

