using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VirtualBarBackend.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/api/hello")]
        public ActionResult<string> Get()
        {
            return "Hello";
        }
    }
}