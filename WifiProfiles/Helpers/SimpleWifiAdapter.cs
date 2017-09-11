using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;

namespace ChangeIPwithWifi.Prototype
{
    public class SimpleWifiAdapter
    {
        private Wifi wifi;

        public SimpleWifiAdapter()
        {
            wifi = new Wifi();          
        }

        public List<String> getAcessPointers()
        {
            List<string> list = new List<string>();

            foreach (AccessPoint ap in wifi.GetAccessPoints())
                list.Add(ap.Name);

            return list;
        }        
    }
}
