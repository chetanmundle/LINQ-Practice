namespace introduction
{
    using LinqDemo1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Syntax01
    {
        public void SyntaxIntro()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /*   var querySyntax = from nums in numbers
                                 where nums % 2 == 0 
                                 select nums;*/                                           //Method 1
            IEnumerable<int> querySyntax = from nums in numbers
                                           where nums % 2 == 0
                                           select nums;                                      //Method 2
            Console.WriteLine("By Query Syntax");
            foreach (var curElm in querySyntax)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("----------------------------------------------------------------");

            //  var methodSyntax = numbers.Where(obj => { return obj % 2 == 0; });   //Method 1
            var methodSyntax = numbers.Where(obj => obj % 2 == 0);           //Method 2
            Console.WriteLine("By Method Syntax");
            foreach (var curElm in methodSyntax)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("----------------------------------------------------------------");

            var mixedSyntax = (from nums in numbers
                               where nums % 2 != 0
                               select nums).Max();
            Console.WriteLine($"Max Value : {mixedSyntax}");

            Console.WriteLine("--------------------------");
            List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=1,Name="Chetan"},
            new Employee(){Id=2,Name="Ramesh"}
        };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            IQueryable<Employee> query1 = employees.AsQueryable().Where(emp => emp.Id == 1);

            foreach (var emp in query1)
            {
                Console.WriteLine($"Emp id : {emp.Id} and Name : {emp.Name}");
            }

            int[] a = { 1, 5, 4, 6, 2, 7, 8, 5, 9, 48, 88 };
            //IEnumerable<int> q = from n in a where n > 10 select n;
            var q = from n in a where n > 5 select n;
            foreach (var curElm in q)
            {
                Console.WriteLine(curElm);
            }
        }
    }



}