using System.ComponentModel.DataAnnotations;

namespace Online_Store.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0, float.MaxValue)]
        [DataType(DataType.Currency)]
        public float Prize { get; set; }

        [Range (0, int.MaxValue)]
        [Required]
        public int Quantity { get; set; }
    }
}
