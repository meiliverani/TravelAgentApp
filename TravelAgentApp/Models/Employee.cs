using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelAgentApp.Models
{
    [Index(nameof(EmployeeNo), IsUnique = true)]
    public class Employee
    {
        [Key] public int Id { get; set; }
        [MaxLength(20)]
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        
    }
}
