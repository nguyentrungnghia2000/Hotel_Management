using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Controls;
using DTO_Hotel;

namespace BUS_Controls
{
    public class BUS_SignIn
    {
        DAL_SignIn dalSignIn = new DAL_SignIn();

        public string SignIn(DTO_SignIn Account)
        {
            //return "csdvdf";
            return dalSignIn.SignIn(Account);
        }

        public string SelectMa(string maacc)
        {
            return dalSignIn.SelectAll(maacc);
        }
    }
}
