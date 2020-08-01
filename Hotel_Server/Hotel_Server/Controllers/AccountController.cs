using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUS_Controls;
using DTO_Hotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotel_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        BUS_SignIn bUS_SignIn = new BUS_SignIn();
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] DTO_SignIn account)
        {
            string result = bUS_SignIn.SignIn(account);
            return new JsonResult(new ResponseAPI<string>(result));
        }
        [HttpGet]
        public async Task<IActionResult> GetManvByAcc(string maacc) // lấy mã nhân viên theo tên tài khoản
        {
            string result = bUS_SignIn.SelectMa(maacc);
            return new JsonResult(new ResponseAPI<string>(result));
        }
    }
}
