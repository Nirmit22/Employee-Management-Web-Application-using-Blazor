using EmployeeManagement.Model;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public bool ShowFooter { get; set; } = true; 
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees=(await EmployeeService.GetEmployees()).ToList();
            
        }

        protected async Task EmployeeDeleted()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        protected int SelectedEmployeesCount { get; set; } = 0;

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }
        /*private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Nirmit",
                LastName = "Ghughu",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "Department1" },
                PhotoPath = "images/image.png"

            };

        Employee e2 = new Employee
        {
            EmployeeId = 1,
            FirstName = "Nirmit",
            LastName = "Ghughu",
            Email = "nirmitghugh@gmail.com",
            DateOfBirth = new DateTime(2000, 12, 22),
            Gender = Gender.Male,
            DepartmentId = 1,// new Department { DepartmentId = 1, DepartmentName = "Department1" },
            PhotoPath = "images/image.png"

            };

            Employee e3 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Nirmit",
                LastName = "Ghughu",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId =1,// new Department { DepartmentId = 1, DepartmentName = "Department1" },
                PhotoPath = "images/image.png"

            };

            Employee e4 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Nirmit",
                LastName = "Ghughu",
                Email = "nirmitghugh@gmail.com",
                DateOfBirth = new DateTime(2000, 12, 22),
                Gender = Gender.Male,
                DepartmentId =1,// new Department { DepartmentId = 1, DepartmentName = "Department1" },
                PhotoPath = "images/image.png"

            };


            Employees = new List<Employee> { e1, e2, e3, e4 };

        }*/
    }
}
