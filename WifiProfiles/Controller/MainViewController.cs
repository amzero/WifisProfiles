using ChangeIPwithWifi.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WifiProfiles.Model;

namespace WifiProfiles.Controller
{
    class MainViewController
    {
        private View.MainView view;
       
        public MainViewController()
        {
            view = new View.MainView();
            view.getBtnAdd().Enabled = false;
            view.getBtnEdit().Enabled = false;
            view.getBtnDelete().Enabled = false;

            view.getBtnRefresh().Click += refreshListWifis;
            view.getWifiListBox().SelectedIndexChanged += wifiSelected;
            view.getProfileListBox().SelectedIndexChanged += profileSelected;
            view.getBtnAdd().Click += addProfile; 
            view.ShowDialog();
        }

        private void addProfile(object sender, EventArgs e)
        {
            WifiModel wifi = new WifiModel("TESTANDO2");
            new ProfileController(wifi);
        }

        private void profileSelected(object sender, EventArgs e)
        {
            view.getBtnEdit().Enabled = true;
            view.getBtnDelete().Enabled = true;
        }

        private void wifiSelected(object sender, EventArgs e)
        {
            view.getBtnAdd().Enabled = true;
            List<string> list = new List<string>();

            view.getProfileListBox().DataSource = list;
        }

        private void refreshListWifis(object sender, EventArgs e)
        {
            view.getBtnRefresh().Enabled = false;
            view.getBtnRefresh().Text = "Loading..";

            SimpleWifiAdapter simplewifi = new SimpleWifiAdapter();

            view.getWifiListBox().DataSource = simplewifi.getAcessPointers();
            view.getBtnRefresh().Text = "Refresh";
            view.getBtnRefresh().Enabled = true;
        }
        
    }
}
