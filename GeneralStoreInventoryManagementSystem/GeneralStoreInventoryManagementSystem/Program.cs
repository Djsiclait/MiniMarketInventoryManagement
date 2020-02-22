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
            #region Localization Settings
            // code source: https://stackoverflow.com/questions/5710127/get-operating-system-language-in-c-sharp
            CultureInfo ci = CultureInfo.InstalledUICulture;

            Console.WriteLine("Default Language Info:");
            Console.WriteLine("* Name: {0}", ci.Name); // use to detect pc default language
            Console.WriteLine("* Display Name: {0}", ci.DisplayName);
            Console.WriteLine("* English Name: {0}", ci.EnglishName);
            Console.WriteLine("* 2-letter ISO Name: {0}", ci.TwoLetterISOLanguageName);
            Console.WriteLine("* 3-letter ISO Name: {0}", ci.ThreeLetterISOLanguageName);
            Console.WriteLine("* 3-letter Win32 API Name: {0}", ci.ThreeLetterWindowsLanguageName);

            // If pc language does not find a locolization intanciation in the code the default language will be English
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ci.Name); // setting the default language according to pc system default language
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ci.Name); // setting the default language according to pc system default language

            // code source: https://www.youtube.com/watch?v=D5cUhEXu8Jg
            var language = ConfigurationManager.AppSettings["language"]; // Fetching the default language established in the App.Config files 

            //Thread.CurrentThread.CurrentCulture = new CultureInfo(language); // setting the default language according to the config files
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(language); // setting the default language according to the config files
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
