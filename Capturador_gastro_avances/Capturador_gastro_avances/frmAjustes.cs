using Capturador_gastro_avances.Properties;
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
    public partial class frmAjustes : Form
    {
        private frmPrincipal insta = null;
        public frmAjustes(frmPrincipal insta)
        {
            this.insta = insta;
            InitializeComponent();
            if (Settings.Default.auto)
                checkAuto.Checked = true;
            else
                checkAuto.Checked = false;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtFolder.Text = fbd.SelectedPath;
                    Properties.Settings.Default.folder_path = fbd.SelectedPath;
                    Console.WriteLine(fbd.SelectedPath);

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.folder_path = txtFolder.Text;
            if (radJpg.Checked)
                Properties.Settings.Default.Image_format = "jpg";
            else
                Properties.Settings.Default.Image_format = "png";

            if (checkAuto.Checked)
                Settings.Default.auto = true;
            else
                Settings.Default.auto = false;


            Properties.Settings.Default.Save();
            this.Close();
            insta.Show();
            this.Dispose();
        }


        [DllImport("user32.DLL", EntryPoint= "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Image_format == "jpg")
                radJpg.Checked = true;
            else
                radPng.Checked = true;
            txtFolder.Text = Properties.Settings.Default.folder_path;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            insta.Show();
            this.Dispose();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked)
                checkAuto.Text = "Desactivar";
            else
                checkAuto.Text = "Activar";
        }
    }
}
