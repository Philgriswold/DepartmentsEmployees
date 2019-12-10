using System;
using DepartmentsEmployee.Data;
using DepartmentsEmployees.Models;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentRepo = new DepartmentRepository();
            var allDepartments = departmentRepo.GetAllDepartments();

            Console.WriteLine("All Departments");
            Console.WriteLine("---------------");

            foreach (var dept in allDepartments)
            {
                Console.WriteLine(dept.DepartmentName);
            }

            var hardCodedId = 3;
            var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodedId);

            Console.WriteLine("-----------");
            Console.WriteLine($"Department with id {hardCodedId} is {departmentWithId3.DepartmentName}");

            /// heres a break-------------------------------------------------------------------------------
            /// ---------------------------------------------------------------------------------------------

            var employeeRepo = new EmployeeRepository();
            var allEmployees = employeeRepo.GetAllEmployees();

            Console.WriteLine("All Employees");
            Console.WriteLine("---------------");

            foreach (var employee in allEmployees)
            {
                Console.WriteLine(employee.FirstName);
            }

            var hardCodedEmployeeId = 2;

            var employeeWithId3 = employeeRepo.GetEmployeeById(hardCodedEmployeeId);

            Console.WriteLine("-----------");
            Console.WriteLine($"Employee with id {hardCodedEmployeeId} is {employeeWithId3.FirstName}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var legal = new Department();
            Console.WriteLine("What department would you like to add?");
            legal.DepartmentName = Console.ReadLine();
            departmentRepo.AddDepartment(legal);

            Console.WriteLine("What Department (ID) would you like to update?");
            var departmentToUpdate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is name of the new department?");
            var newDepartmentName = Console.ReadLine();
            departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DepartmentName = newDepartmentName });

            //Add a new employee
            

            departmentRepo.DeleteDepartment(7);
            departmentRepo.DeleteDepartment(8);
            departmentRepo.DeleteDepartment(9);
        }
    }
}
