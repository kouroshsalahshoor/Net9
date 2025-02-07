using System.ComponentModel.DataAnnotations;

namespace SportsStore.Auto.Client.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;
    }
}
