using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    [Index(nameof(InventoryNo), IsUnique = true)]
    public class Inventory
    {
        [Key] public int Id { get; set; }
        [Required]  
        public string InventoryNo { get; set; }
        public DateTime InventoryDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public DateTime? StartValidDate { get; set; }
        public DateTime? EndValidDate { get; set;}
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
