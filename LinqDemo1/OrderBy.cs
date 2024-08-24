using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class OrderBy
    {
        public void OrderByMethod()
        {
            var intData = new List<int>() { 100, 5, 12, 13, 1, 7, 53, 35 };
            Console.WriteLine("Befor Order By : ");

            intData.ForEach(num => Console.Write($"{num}\t"));

            var orderByQuery = (from num in intData
                                orderby num
                               select num).ToList();                                 // OR

            var orderByMethod = intData.OrderBy(num => num).ToList();


            Console.WriteLine("\n After Apply Order by : ");
            foreach(var curElm in orderByQuery)
            {
                Console.Write($"{curElm}\t");
            }



            Console.WriteLine("\n\n-------------------------------------------------------------------------");
            Console.WriteLine("\n\n Data which is the integers are greater than 10 and order by : ");

            var conditionQuery = (from num in intData
                                 where num > 10
                                 orderby num
                                 select num).ToList();

            var conditionMethod = intData.Where(num => num > 10).OrderBy(num=> num).ToList();

            conditionMethod.ForEach(num => Console.Write($"{num}\t"));




            Console.WriteLine("\n\n-------------------------------------------------------------------------");

            Console.WriteLine("ORder by in string");
            var names = new List<string>() { "Chetan", "rahul", "Aman", "Yugal", "Vinit", "Raunit" };

            var stringOrderByQ = (from name in names
                                  orderby name
                                  select name).ToList();                                                       // OR

            var stringOrderByM = names.OrderBy(name => name).ToList();

            foreach(var name in stringOrderByQ)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("\n\n-------------------------------------------------------------------------");

            var dataSource = new List<Employee2>()
            {
               new Employee2(){Id=4,Name = "Aman",Email="c@gmail.com"},
               new Employee2(){Id=3,Name = "Kunal",Email="c@gmail.com"},
               new Employee2(){Id=2,Name = "Raju",Email="c@gmail.com"},
               new Employee2(){Id=5,Name = "HArry",Email="c@gmail.com"},                
               new Employee2(){Id=1,Name = "Chetan",Email="c@gmail.com"},
            };

            var sortByidQ = (from emp in dataSource
                             orderby emp.Id
                             select emp).ToList();

            var sortByidM = dataSource.OrderBy(emp => emp.Id).ToList();

            Console.WriteLine("Sorted Data : ");

            foreach(var emp in sortByidM)
            {
                Console.WriteLine($"ID : {emp.Id}, Name : {emp.Name} and Email : {emp.Email}");
            }


        }
    }
}
