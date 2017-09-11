using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WifiProfiles.Collector;
using WifiProfiles.Controller;
using WifiProfiles.DAO;

namespace WifiProfiles
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
            //Application.Run();
            string filepath = "C:";
            IDAO dao = new JSONDAO(filepath);
            ProfileCollectors profiles = new ProfileCollectors(dao);
            new MainViewController();            
        }
    }
}
