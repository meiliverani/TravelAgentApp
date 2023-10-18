using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgentApp.Models
{
    public class CategoryMapping
    {
        [Key] 
        public int Id { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        [ForeignKey("ProductSubCategory")]
        public int SubCategoryId { get; set; }
        public ProductSubCategory SubCategory { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
