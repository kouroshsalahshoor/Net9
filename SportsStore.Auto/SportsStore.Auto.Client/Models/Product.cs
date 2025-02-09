using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Auto.Client.Models
{
    public class Product
    {
        public long? Id { get; set; }
        [Required(ErrorMessage = "Please enter a product {0}")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a {0}")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive {0}")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please specify a {0}")]
        public string Category { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
    }
}
