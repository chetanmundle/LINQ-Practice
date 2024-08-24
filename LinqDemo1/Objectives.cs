using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LinqDemo1
{
    internal class Objectives
    {
       public void Objecgivemethod()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Chetan",Email ="x@gmail.com"},
                new Employee(){Id=2,Name="Rohit",Email ="x@gmail.com"},
                new Employee(){Id=3,Name="Sandesh",Email ="x@gmail.com"},
                new Employee(){Id=4,Name="Raju",Email ="x@gmail.com"},
                new Employee(){Id=5,Name="Santosh",Email ="x@gmail.com"},
                new Employee(){Id=6,Name="Ramesh",Email ="x@gmail.com"},
            };
            var basicQuery = (from emp in employees 
                              select emp).ToList();    
            //OR
            var basicMethod = employees.ToList();
            Console.WriteLine("View All the Employees => \n");
            foreach(var emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.Id}, Name : {emp.Name}, Emial : {emp.Email}");
            }

            //Select Only Names By query
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select Only Names of the Employees : ");
            var basicNameMethod = employees.Select(emp => emp.Name).ToList();                            //OR
            var basicNameQuery = from emp in employees 
                                 select emp.Name;

            foreach(var curElm in basicNameQuery)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Number to string");
            var basicIdtoStringQuery = (from emp in employees
                                        select emp.Id.ToString()).ToList();
            foreach (var curElm in basicIdtoStringQuery)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("\n\n--------------------------------------------------------");
            Console.WriteLine("Get ID and Email Only :");
            var idEmailQuery = (from emp in employees
                                select new Employee()
                                {
                                    Id = emp.Id,
                                    Name = emp.Name,
                                }).ToList() ;


            var idEmailMethod = employees.Select(emp => new Employee() { Id = emp.Id, Name = emp.Name }).ToList();

            foreach(var emp in idEmailMethod)
            {
                Console.WriteLine($"{emp.Id} : {emp.Name}");
            }

            Console.WriteLine("\n\n--------------------------------------------------------");
            Console.WriteLine("Setting up the Employee Class data to student :");

            var studnetQuery = (from emp in employees
                                select new Student()
                                {
                                    StId = emp.Id,
                                    StName = emp.Name,
                                    StEmail = emp.Email,
                                }).ToList();

            var studentMethod = employees.Select(emp => new Student()
            {
                StId = emp.Id,
                StName = emp.Name,
                StEmail = emp.Email,
            }).ToList();

            foreach (var curEmp in studentMethod)
            {
                Console.WriteLine($"Student Id : {curEmp.StId} and Studnet Nm : {curEmp.StName} and Student Emial : {curEmp.StEmail}");
            }

            Console.WriteLine("\n\n--------------------------------------------------------");
            Console.WriteLine("Anonomus type :");

            var studnetQueryAynonomus = (from emp in employees
                                select new 
                                {
                                    CustomId = emp.Id,
                                    CustomName = emp.Name,
                                    CustomEmail = emp.Email,
                                }).ToList();
            foreach (var curEmp in studnetQueryAynonomus)
            {
                Console.WriteLine($"Custom Id : {curEmp.CustomId} and Custom Nm : {curEmp.CustomName} and Custom Emial : {curEmp.CustomEmail}");
            }


            Console.WriteLine("\n\n--------------------------------------------------------");
            Console.WriteLine("Select Index and Name:");
            var indexMethod = employees.Select((emp,index)=> new {Index = index,Name = emp.Name}).ToList();
            foreach(var curEmp in indexMethod)
            {
                Console.WriteLine($"Index : {curEmp.Index} and Name : {curEmp.Name}");
            }
        }
    }
}
