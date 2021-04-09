using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace olympics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start_Page());
            //Application.Run(new OlympicsGamesAdmin());
            //Application.Run(new OlympicsGamesUser("Lonwabo"));
        }
    }
}
