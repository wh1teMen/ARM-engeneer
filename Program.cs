using Microsoft.EntityFrameworkCore;
using ProgectE;
using ProgectE.Forms.Admin;
using System.Runtime.CompilerServices;


namespace PogectE
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
            Application.Run(new Authorization());
            




        }
    }
}