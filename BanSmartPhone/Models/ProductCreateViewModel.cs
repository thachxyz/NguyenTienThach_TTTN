using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace BanSmartPhone.Models
{
    public class ProductCreateViewModel
    {
        public string? Alias { get; set; }

        public string? Detail { get; set; }

        public string NameProduct { get; set; } = null!;

        public double? Price { get; set; }

        public double? SalePrice { get; set; }

        public long? BrandId { get; set; }

        public long? CategoryId { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
