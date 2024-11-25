using System.ComponentModel.DataAnnotations;

namespace LoginForm.Models
{
    public class Login
    {
              
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
