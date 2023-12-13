using System.ComponentModel.DataAnnotations;
// CompanyDetailsDto.cs
namespace DejaVu.Models
{
    public class CompanyDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfEmployees { get; set; }

        public string FullAddress { get; set; }
    }
}
