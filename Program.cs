using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company krustyKrab = new Company("The Krusty Krab", DateTime.Now);

            // Create three employees
            List<Employee> employeeList = new List<Employee>(){
                new Employee(){
                    FirstName = "Eugene",
                    LastName = "Krabs",
                    Title = "Owner",
                    StartDate = DateTime.Now
                },
                new Employee() {
                    FirstName = "Squidward",
                    LastName = "Tentacles",
                    Title = "Cashier",
                    StartDate = DateTime.Now
                },
                new Employee() {
                    FirstName = "SpongeBob",
                    LastName = "SquarePants",
                    Title = "Frycook",
                    StartDate = DateTime.Now
                }
            };

            // Assign the employees to the company
            krustyKrab.Employees.AddRange(employeeList);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            krustyKrab.ListEmployees();
        }
    }


}