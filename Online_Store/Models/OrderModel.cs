using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Online_Store.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string? ProductName { get; set; }
        public float Prize { get; set; }
        public List<Product>? Products { get; set; }
        [Required]
        public string? Address { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        [RegularExpression(@"^\\?([0-9]{3})\)?[- ]?([0-9]{3})?[- ]?([0-9]{3})$", ErrorMessage = "The Phone Number field is not a valid phone number")]
        public string? PhoneNumber { get; set; }
    }
}
