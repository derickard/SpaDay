using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required, StringLength(15, MinimumLength = 5, ErrorMessage = "Username between 5 and 15 characters.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(20, MinimumLength = 6, ErrorMessage = "Password bewteen 6 and 20 characters.")]
        public string Password { get; set; }

        [Required, StringLength(20, MinimumLength = 6, ErrorMessage = "Password bewteen 6 and 20 characters.")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string VerifyPassword { get; set; }
    }
}
