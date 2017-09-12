using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WifiProfiles.DAO;
using WifiProfiles.Model;

namespace WifiProfiles.Collector
{
    class ProfileCollectors
    {
        List<ProfileModel> profiles;
        private IDAO dao;

        public ProfileCollectors(IDAO dao)
        {
            profiles = new List<ProfileModel>();
            
        }
    }
}
