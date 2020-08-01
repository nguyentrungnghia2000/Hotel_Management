using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUS_Controls;
using DTO_Hotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        BUS_Phong bus_p = new BUS_Phong();
       //public async Task<IActionResult> AddRoom([FromBody] DTO_Phong room)
       // {

       // }
    }
}
