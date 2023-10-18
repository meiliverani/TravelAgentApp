using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryMappingId { get; set; }
        public CategoryMapping CategoryMapping { get; set; }
        [Required]
        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        [Precision(10,2)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
