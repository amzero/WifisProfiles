using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiProfiles.DAO
{
    interface IDAO
    {
        bool getAllProfiles();
        bool updateAllProfiles();
        bool deleteProfile();
        bool addProfile();
    }
}
