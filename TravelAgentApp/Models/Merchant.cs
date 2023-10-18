using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    public class Merchant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        //Username and Password are used to access Merchant's Portal
        public string Username { get; set; } 
        public string Password { get; set; }
        public string Address { get; set; }
        //ApiUrl is used to store the API provided by the Merchant to do integration
        public string? ApiUrl { get; set; }
        public string? ContentType { get; set; }
        public string? RequestMethod { get; set; }
        public string? Token { get; set; }
        public bool IsIntegrated { get; set; } = false;
        //public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
