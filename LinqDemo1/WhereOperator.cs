using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class WhereOperator
    {
        public void WhereOperatorMethod()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var graterThan5Query = from num in numbers
                                   where num > 5
                                   select num;                                                             // OR

            var greaterThan5Method = numbers.Where(num => num > 5).ToList()
                ;
            Console.WriteLine("All Elements Which is Greater Than 5 : ");
            foreach(var curElm in graterThan5Query)
            {
                Console.WriteLine(curElm);
            }


            Console.WriteLine("\n\n---------------------------------------------------------------------------------");
            var greaterlessThanQ = (from num in numbers
                                   where num > 3 && num < 8
                                   select num).ToList();

            var greaterlessThanM = numbers.Where(num => num < 8 && num > 3).ToList();

            Console.WriteLine("Greater then 3 and less than 8 : ");

            foreach(var curElm in greaterlessThanM)
            {
                Console.WriteLine(curElm);
            }


            Console.WriteLine("\n\n---------------------------------------------------------------------------------");
            var orOperatorQ = (from num in numbers
                                    where num < 3 || num > 8
                                    select num).ToList();

            var orOperatorM = numbers.Where(num => num > 8 || num < 3).ToList();

            Console.WriteLine("Less then 3 and Greater than 8 : ");

            foreach (var curElm in greaterlessThanM)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("\n\n---------------------------------------------------------------------------------");

            var names = new List<string>() { "joy","chetan","Ram","Lokesh","Prashant","Yugal"};
            var equlTo3Q = (from name in names
                             where name.Length == 3
                             select name).ToList();

            var equlTo3M = names.Where(name => name.Length == 3).ToList();
            foreach(var curElm in equlTo3Q)
            {
                Console.WriteLine(curElm);
            }


            Console.WriteLine("\n\n---------------------------------------------------------------------------------");

            var dataSource = new List<Employee2>()
            {
                new Employee2()
                {
                    Id = 1,Name ="Chetan",Email="X@gmail.com",Programming =
                    new List<Techs>
                    {
                        new Techs(){Technology = "Java"},
                        new Techs(){Technology = "Python"},
                        new Techs(){Technology = "CPP"},
                         new Techs(){Technology = "HTML"},
                        new Techs(){Technology = "CSS"},
                    }
                },
                new Employee2()
                {
                    Id = 1,Name ="Rahul",Email="X@gmail.com",Programming =
                    new List<Techs>
                    {
                        new Techs(){Technology = "Kotlin"},
                        new Techs(){Technology = "SQL"},
                        new Techs(){Technology = "LINQ"},
                    }
                },
                new Employee2()
                {
                    Id = 1,Name ="Lokesh",Email="X@gmail.com",Programming =
                    new List<Techs>
                    {
                        new Techs(){Technology = "React"},
                        new Techs(){Technology = "CPP"},
                    }
                },
                new Employee2()
                {
                    Id = 1,Name ="Kaushik",Email="X@gmail.com",Programming =
                    new List<Techs>()
                },
                 new Employee2()
                {
                    Id = 1,Name ="Padmesh",Email="X@gmail.com",Programming =
                    new List<Techs>()
                },

            };


            var noTechnologyQ = (from emp in dataSource
                                 where emp.Programming.Count() == 0
                                 select emp.Name).ToList();

            var noTechnologyM = dataSource.Where(emp => emp.Programming.Count() == 0).ToList();

            foreach (var curElm in noTechnologyQ)
            {
                Console.WriteLine(curElm);
            }




        }
    }
}
