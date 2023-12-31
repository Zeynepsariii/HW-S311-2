﻿using System.ComponentModel.DataAnnotations;

namespace DejaVu.Models
{
    
        public class Employee
        {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }


        [Required]
        [MinLength(3)]
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [MinLength(3)]
        public string Position { get; set; }
        public string Image { get; set; }

        public int CompanyId { get; set; } // Foreign key
        public Company Company { get; set; } // Navigation property
        public SalaryInfo SalaryInfo { get; set; }
         public decimal NetSalary { get; set; }
        public decimal GrossSalary { get; set; }
    }

}



