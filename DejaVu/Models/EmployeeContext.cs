using DejaVu.Models;
using Microsoft.EntityFrameworkCore;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; } // Ensure you have this DbSet for Companies

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Companies
        modelBuilder.Entity<Company>().HasData(
            new Company { Id = 1, Name = "Tech Innovations", Zipcode = "10001", City = "New York", Country = "USA" },
            new Company { Id = 2, Name = "Green Solutions", Zipcode = "94016", City = "San Francisco", Country = "USA" },
            new Company { Id = 3, Name = "Bright Future Solar", Zipcode = "75001", City = "Paris", Country = "France" },
            new Company { Id = 4, Name = "Oceanic Research Ltd", Zipcode = "60505", City = "London", Country = "UK" },
            new Company { Id = 5, Name = "Mountain Adventures", Zipcode = "80020", City = "Boulder", Country = "USA" }
        );

        // Seed Employees with CompanyId
        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "Martin", Surname = "Simpson", BirthDate = new DateTime(1992, 12, 3), Position = "Marketing Expert", Image = "/images/Martin.jpg", CompanyId = 1 },
            new Employee { Id = 2, Name = "Jacob", Surname = "Hawk", BirthDate = new DateTime(1995, 10, 2), Position = "Manager", Image = "/images/Jacob.jpg", CompanyId = 2 },
            new Employee { Id = 3, Name = "Elizabeth", Surname = "Geil", BirthDate = new DateTime(2000, 1, 7), Position = "Software Engineer", Image = "/images/Elizabeth.jpg", CompanyId = 3 },
            new Employee { Id = 4, Name = "Kate", Surname = "Metain", BirthDate = new DateTime(1997, 2, 13), Position = "Admin", Image = "/images/Kate.jpg", CompanyId = 4 },
            new Employee { Id = 5, Name = "Michael", Surname = "Cook", BirthDate = new DateTime(1990, 12, 25), Position = "Marketing Expert", Image = "/images/Michael.jpg", CompanyId = 5 },
            new Employee { Id = 6, Name = "John", Surname = "Snow", BirthDate = new DateTime(2001, 7, 15), Position = "Software Engineer", Image = "/images/John.jpg", CompanyId = 1 },
            new Employee { Id = 7, Name = "Nina", Surname = "Soprano", BirthDate = new DateTime(1999, 9, 30), Position = "Software Engineer", Image = "/images/Nina.jpg", CompanyId = 2 },
            new Employee { Id = 8, Name = "Tina", Surname = "Fins", BirthDate = new DateTime(2000, 5, 14), Position = "Team Leader", Image = "/images/Tina.jpg", CompanyId = 3 }
        );

        // Configurations with Fluent API
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Company)
            .WithMany(c => c.Employees)
            .HasForeignKey(e => e.CompanyId);

        modelBuilder.Entity<Employee>()
             .HasOne(e => e.SalaryInfo)
             .WithOne(s => s.Employee)
             .HasForeignKey<SalaryInfo>(s => s.EmployeeId);

    }
}
