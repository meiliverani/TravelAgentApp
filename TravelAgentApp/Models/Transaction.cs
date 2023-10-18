using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    [Index(nameof(TransactionNo), IsUnique = true)]
    public class Transaction
    {
        [Key] public int Id { get; set; }
        [Required]
        public string TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
