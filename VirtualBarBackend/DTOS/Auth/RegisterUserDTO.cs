using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualBarBackend.DTOS
{
    public class RegisterUserDTO
    {
        [Required]
        public string firstName;

        [Required]
        public string lastName;

        [Required]
        [EmailAddress]
        public string eMail;
    }
}
