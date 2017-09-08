using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;

namespace ChangeIPwithWifi.Prototype
{
    public class Class1
    {
        public Class1()
        {
            Wifi wifi = new Wifi();
            wifi.GetAccessPoints();
            foreach (AccessPoint ap in wifi.GetAccessPoints())
            {
                Console.WriteLine(ap.Name);
                String name = ap.Name;
                if (name.Equals("TESTANDO2"))
                {
                    Console.WriteLine("ENCONTRADO!");
                }
            }           
        }        
    }
}
