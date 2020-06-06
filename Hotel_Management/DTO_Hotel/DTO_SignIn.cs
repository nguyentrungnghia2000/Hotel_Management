using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_SignIn
    {
        private string _user;
        private string _pass;

        public string user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        public string pass
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
            }
        }

        public DTO_SignIn(string user, string pass)
        {
            this._user = user;
            this._pass = pass;
        }
    }
}
