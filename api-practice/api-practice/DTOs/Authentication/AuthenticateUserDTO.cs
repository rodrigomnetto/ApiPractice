using System.ComponentModel.DataAnnotations;

namespace ApiPractice.DTOs.Authentication
{
    public class AuthenticateUserDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
