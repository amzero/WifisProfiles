using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WifiProfiles.Model;
using WifiProfiles.View;

namespace WifiProfiles.Controller
{
    class ProfileController
    {
        private ProfileView view;
        private ProfileModel profile;

        public ProfileController(WifiModel wifi)
        {
            this.view = new ProfileView();
            this.view.ShowDialog();

        }



        
    }
}
