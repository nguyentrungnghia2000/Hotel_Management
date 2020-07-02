using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class DAL_CTDV
    {
        private string connectionSTR = null;

        public DAL_CTDV()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

    }
}
