using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    [Index(nameof(BookingNo), IsUnique = true)]
    public class Booking
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string BookingNo { get; set; }
        public DateTime BookingDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Qty { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set;}
        [Precision(10,2)]
        public decimal TotalPrice { get; set; }
        public int BookingStatusId { get; set; }
        public BookingStatus? BookingStatus { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
