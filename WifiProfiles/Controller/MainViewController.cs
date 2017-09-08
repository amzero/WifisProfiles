using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiProfiles.Controller
{
    class MainViewController
    {
        private View.MainView view;

        public MainViewController()
        {
            view = new View.MainView();



            view.Show();
        }
    }
}
