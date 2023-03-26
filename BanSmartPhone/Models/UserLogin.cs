namespace BanSmartPhone.Models
{
    public class UserLogin
    {
        public string Email { get; set; }
        public string FullName { get; set; }

        public string Username { get; set; } = string.Empty;

        public long Id { get; set; }        
    }
}
