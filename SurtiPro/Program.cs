using System;
using System.Windows.Forms;
using SurtiPro; // Asegúrate de agregar el espacio de nombres correspondiente, si es necesario.

namespace SurtiPro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cambiar 'Form1' por 'ProductForm' aquí:
            Application.Run(new VentanaPrincipal());
        }
    }
}
