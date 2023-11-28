﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DejaVu.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20231128192314_UpdateEmployeeWithCompanyId")]
    partial class UpdateEmployeeWithCompanyId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DejaVu.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            Country = "USA",
                            Name = "Tech Innovations",
                            Zipcode = "10001"
                        },
                        new
                        {
                            Id = 2,
                            City = "San Francisco",
                            Country = "USA",
                            Name = "Green Solutions",
                            Zipcode = "94016"
                        },
                        new
                        {
                            Id = 3,
                            City = "Paris",
                            Country = "France",
                            Name = "Bright Future Solar",
                            Zipcode = "75001"
                        },
                        new
                        {
                            Id = 4,
                            City = "London",
                            Country = "UK",
                            Name = "Oceanic Research Ltd",
                            Zipcode = "60505"
                        },
                        new
                        {
                            Id = 5,
                            City = "Boulder",
                            Country = "USA",
                            Name = "Mountain Adventures",
                            Zipcode = "80020"
                        });
                });

            modelBuilder.Entity("DejaVu.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 1,
                            Image = "/images/Martin.jpg",
                            Name = "Martin",
                            Position = "Marketing Expert",
                            Surname = "Simpson"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 2,
                            Image = "/images/Jacob.jpg",
                            Name = "Jacob",
                            Position = "Manager",
                            Surname = "Hawk"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 3,
                            Image = "/images/Elizabeth.jpg",
                            Name = "Elizabeth",
                            Position = "Software Engineer",
                            Surname = "Geil"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 4,
                            Image = "/images/Kate.jpg",
                            Name = "Kate",
                            Position = "Admin",
                            Surname = "Metain"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 5,
                            Image = "/images/Michael.jpg",
                            Name = "Michael",
                            Position = "Marketing Expert",
                            Surname = "Cook"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2001, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 1,
                            Image = "/images/John.jpg",
                            Name = "John",
                            Position = "Software Engineer",
                            Surname = "Snow"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 2,
                            Image = "/images/Nina.jpg",
                            Name = "Nina",
                            Position = "Software Engineer",
                            Surname = "Soprano"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 3,
                            Image = "/images/Tina.jpg",
                            Name = "Tina",
                            Position = "Team Leader",
                            Surname = "Fins"
                        });
                });

            modelBuilder.Entity("DejaVu.Models.SalaryInfo", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Net")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.ToTable("SalaryInfo");
                });

            modelBuilder.Entity("DejaVu.Models.Employee", b =>
                {
                    b.HasOne("DejaVu.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DejaVu.Models.SalaryInfo", b =>
                {
                    b.HasOne("DejaVu.Models.Employee", "Employee")
                        .WithOne("SalaryInfo")
                        .HasForeignKey("DejaVu.Models.SalaryInfo", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DejaVu.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DejaVu.Models.Employee", b =>
                {
                    b.Navigation("SalaryInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}