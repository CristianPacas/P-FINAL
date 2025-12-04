using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_FINAL_U20240388.Forms;
using P_FINAL_U20240388.Repositorios;
using System.Configuration;
using System.Data.SqlClient;




namespace P_FINAL_U20240388
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
            Application.Run(new frmSignUp()); // <-- pásalo al formulario
        }
    }
}
