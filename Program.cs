using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoApi
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new Form1();
            frm.FormClosed += frm_FormClosed;
            frm.ShowDialog();
            Application.Run();
        }
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
