using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApp
{
    class ConnectionString
    {
        public string DBConn()
        {
           //sring str = "Data Source=EMNA-SDSI-DJ;Initial Catalog=DB_RH_POLICE";
            string str = "Server=EMNA-SDSI-DJ; Database=DB_RH_POLICE; Trusted_Connection=Yes";

            return str;
        }
    }
}
