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
    public partial class frmDatos : Form
    {

        string nombre = string.Empty;
        frmPrincipal insta = null;
        public frmDatos(frmPrincipal insta)
        {
            this.insta = insta;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            insta.Show();
            this.Dispose();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Hide();
            nombre = txtNombre.Text;
            frmSesion sesion = new frmSesion(nombre, insta);
            sesion.Show();
            this.Dispose();
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
