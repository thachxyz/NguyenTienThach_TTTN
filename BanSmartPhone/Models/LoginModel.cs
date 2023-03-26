using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Models
{
    public class LoginModel 
    {
        public string? UserName { get; set; } 
        public string? Password { get; set; }
        
    }
}
