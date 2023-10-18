using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class PaymentMethod
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
