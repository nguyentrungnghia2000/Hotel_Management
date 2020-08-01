using DAL_Hotel;
using DTO_Hotel;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_SignIn
    {
        DAL_SignIn dalSignIn = new DAL_SignIn();

        public async Task<string> SignIn(DTO_SignIn Account)
        {
            ResponseAPI<string> responseAPI = await ConnectAPI.ConnectAPI.Instance.Post<ResponseAPI<string>>(ConnectAPI.APIRoute.Account.Login, Account);
            if (responseAPI.IsSuccess)
                return responseAPI.Result;
            return "0";
        }

        public async Task<string> GetManvByAcc(string accid)
        {
            ResponseAPI<string> response = await ConnectAPI.ConnectAPI.Instance.Get<ResponseAPI<string>>(string.Format(ConnectAPI.APIRoute.Account.GetManvByAcc,accid));
            if (response.IsSuccess)
                return response.Result;
            return "0";
        }
    }
}
