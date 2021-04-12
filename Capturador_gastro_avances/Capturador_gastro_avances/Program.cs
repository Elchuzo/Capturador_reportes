using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturador_gastro_avances
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       // [Obsolete]
        static void Main()
        {
            //var path = Thread.GetDomain().BaseDirectory + @"bin\ffmpeg\";
            //var dllDirectory = path;
            //Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";"
            //+ dllDirectory);
            //AppDomain.CurrentDomain.AppendPrivatePath(path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
