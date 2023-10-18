using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<CategoryMapping> CategoryMappings { get; set; }
    }
}
