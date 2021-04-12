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
    public partial class frmCantidad : Form
    {
        private int n = 0;
        public frmCantidad()
        {
            InitializeComponent();
        }

        private void frmCantidad_Load(object sender, EventArgs e)
        {
            comboImagenes.SelectedIndex = 0;
            
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            int n = int.Parse(comboImagenes.SelectedItem.ToString());
            Console.WriteLine(n.ToString());
            frmReportes repo = new frmReportes(n);
            repo.Show();
            this.Close();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
