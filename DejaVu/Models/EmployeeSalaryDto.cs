using System.ComponentModel.DataAnnotations;
// EmployeeSalaryDto.cs
namespace DejaVu.Models
{
    public class EmployeeSalaryDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public decimal NetSalary { get; set; }
        public decimal GrossSalary { get; set; }
    }
}
