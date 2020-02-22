using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GeneralStoreInventoryManagementSystem
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;

            Console.WriteLine("Default Language Info:");
            Console.WriteLine("* Name: {0}", ci.Name); // use to detect pc default language
            Console.WriteLine("* Display Name: {0}", ci.DisplayName);
            Console.WriteLine("* English Name: {0}", ci.EnglishName);
            Console.WriteLine("* 2-letter ISO Name: {0}", ci.TwoLetterISOLanguageName);
            Console.WriteLine("* 3-letter ISO Name: {0}", ci.ThreeLetterISOLanguageName);
            Console.WriteLine("* 3-letter Win32 API Name: {0}", ci.ThreeLetterWindowsLanguageName);
            
            // code source: https://www.youtube.com/watch?v=D5cUhEXu8Jg
            var language = ConfigurationManager.AppSettings["language"]; // Fetching the default language established in the App.Config files 

            Thread.CurrentThread.CurrentCulture = new CultureInfo(language); // setting the default language according to the config files
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language); // setting the default language according to the config files

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
