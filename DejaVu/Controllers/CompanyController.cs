// CompanyController.cs
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DejaVu.Models;

namespace DejaVu.Controllers
{
    public class CompanyController : Controller
    {
        private readonly EmployeeContext _context;

        public CompanyController(EmployeeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.Companies
                .Select(c => new CompanyDetailsDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullAddress = $"{c.Address}, {c.City}, {c.Country}",
                    NumberOfEmployees = c.Employees.Count()
                })
                .ToList();

            return View(companies);
        }
    }
}
