using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiProfiles.DAO
{
    class JSONDAO : IDAO
    {
        private string filepath;

        public JSONDAO(string filepath)
        {
            this.filepath = filepath;
        }

        public bool addProfile()
        {
            return true;
        }

        public bool deleteProfile()
        {
            return true;
        }

        public bool getAllProfiles()
        {
            return true;
        }

        public bool updateAllProfiles()
        {
            return true;
        }
    }
}
