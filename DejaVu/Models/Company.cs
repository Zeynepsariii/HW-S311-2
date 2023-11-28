using System.ComponentModel.DataAnnotations;

namespace DejaVu.Models
{

    public class Company
    {
        public int Id { get; set; }

        [MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, StringLength(5, MinimumLength = 5)]
        public string Zipcode { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(60)]
        public string Country { get; set; }

        // Navigation property for the one-to-many relationship with Employee
        public List<Employee> Employees { get; set; }
    }

}