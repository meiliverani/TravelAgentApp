using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public byte[]? IdentityCard { get; set; }
        public bool IsVerified { get; set; } = false;
        //public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
