using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualBarBackend.Models;

namespace VirtualBarBackend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public ActionResult<string> Get([FromBody] UserModel userModel)
        {
            Console.WriteLine("Gosho");
            Console.WriteLine(userModel);

            return "Hey gosho";
        }
    }
}
