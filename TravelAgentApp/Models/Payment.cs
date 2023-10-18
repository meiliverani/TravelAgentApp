using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class Payment
    {
        [Key] public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [Precision(10,2)]
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsVerified { get; set; } = false;
        public string VerifiedBy { get; set; }
        public DateTime VerifiedOn { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
