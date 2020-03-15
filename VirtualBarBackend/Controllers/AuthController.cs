using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualBarBackend.DTOS;
using VirtualBarBackend.Models;
using VirtualBarBackend.Service;

namespace VirtualBarBackend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService userService)
        {
            _authService = userService;
        }


        [HttpPost("register")]
        public ActionResult<RegisterUserDTO> Register(RegisterUserDTO registerUserDTO)
        {
            _authService.RegisterUser(registerUserDTO);
            return registerUserDTO;
        }
    }
}
