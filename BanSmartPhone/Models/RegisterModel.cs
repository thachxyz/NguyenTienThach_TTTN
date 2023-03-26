using System.ComponentModel.DataAnnotations;

namespace BanSmartPhone.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }


        public string FullName { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConFirmPassword { get; set; }
    }
}
