using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Nirmita",
                LastName = "Ghughua",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/image.png"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Nirmite",
                LastName = "Ghughue",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/image.png"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Nirmiti",
                LastName = "Ghughui",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/image.png"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Nirmito",
                LastName = "Ghughuo",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/image.png"

            });
        }

    }
}
