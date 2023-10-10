using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Consola
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

            frmAcceso fAcceso = new frmAcceso();
            if (fAcceso.ShowDialog() == DialogResult.OK)
            {
                Bienvenida bienvenida = new Bienvenida();
                if (bienvenida.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Menu());
                }
            }
        }
    }
}
