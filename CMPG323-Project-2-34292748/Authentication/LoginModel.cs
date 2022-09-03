using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}
