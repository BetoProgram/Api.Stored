using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password requerido")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "El password no son iguales")]
        public string ConfirmPassword { get; set; }
        public string Image { get; set; }
    }
}
