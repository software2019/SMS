using System.ComponentModel.DataAnnotations;
using SMS.Data.Models;

namespace SMS.Web.Models
{
    public class UserViewModel
    {
        [Required]
        public string Username { get; set; }
 
        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string PasswordConfirm  { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}