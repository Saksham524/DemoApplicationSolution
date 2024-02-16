using System;
using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" },
                new Department { DepartmentId = 2, DepartmentName = "HR" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Saksham",
                    Email = "saksham.bca1922@gmail.com",
                    DateOfBirth = new DateTime(2002, 11, 07),
                    DepartmentId = 1  // DepartmentId for IT
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Darshan",
                    Email = "darshan@example.com",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    DepartmentId = 2  // DepartmentId for HR
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Sonu",
                    Email = "sonu@example.com",
                    DateOfBirth = new DateTime(1995, 5, 15),
                    DepartmentId = 1  // DepartmentId for IT
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
