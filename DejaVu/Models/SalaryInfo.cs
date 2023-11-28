using System.ComponentModel.DataAnnotations;

namespace DejaVu.Models
{
    public class SalaryInfo
    {
        [Key]
        public int EmployeeId { get; set; } // Primary key and foreign key

        [Required]
        public decimal Net { get; set; }

        [Required]
        public decimal Gross { get; set; }

        public Employee Employee { get; set; } // Navigation property
    }
}
