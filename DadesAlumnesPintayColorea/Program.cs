using System;
using System.Windows.Forms;

namespace DadesAlumnesPintayColorea
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
            Application.Run(new Dades_Alumnes_Joc_Pintar.formJocPintar());
        }
    }
}
