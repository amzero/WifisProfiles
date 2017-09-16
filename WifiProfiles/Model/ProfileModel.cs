using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiProfiles.Model
{
    class ProfileModel
    {
        private string name;
        public WifiModel wifi { get { return this.wifi; } set { this.wifi = wifi; } }
        private string ip { get; set; }
        private string subnetmask;
        private string gateway;
        private string dns1;
        private string dns2;

        public ProfileModel()
        {

        }

        public ProfileModel(WifiModel wifi, string ip, string subnetmask, string gateway, string dns1, string dns2)
        {
            this.wifi = wifi;
            this.ip = ip;
            this.subnetmask = subnetmask;
            this.gateway = gateway;
            this.dns1 = dns1;
            this.dns2 = dns2;
        }
    }
}
