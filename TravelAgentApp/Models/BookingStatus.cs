using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class BookingStatus
    {
        [Key] public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
