using System.ComponentModel.DataAnnotations;

namespace SocialApp.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}