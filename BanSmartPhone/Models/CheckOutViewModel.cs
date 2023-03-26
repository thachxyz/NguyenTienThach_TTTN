using DAO.Entity;

namespace BanSmartPhone.Models
{
    public class CheckOutViewModel
    {

        List<Cart> carts { get; set; } = new List<Cart>();
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }


        public string Time { get; set; }

        public string PaymentMethod { get; set; }

        public CheckOutViewModel() { }

    }
}
