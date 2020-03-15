using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualBarBackend.DTOS.Auth
{
    public class LoginUserDTO
    {
        [Required]
        public string eMail;

        [Required]
        public string plainPassword;
    }
}
