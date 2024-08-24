using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class SelectMany2
    {
        public void SelectManyMethod()
        {
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
                        new Techs(){Technology = "Js"},
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

            var methodQuery = dataSource.SelectMany(emp => emp.Programming).ToList();

            var querysyntax = (from emp in dataSource
                               from pro in emp.Programming
                              select pro.Technology).ToList();

            foreach(var curElm in querysyntax)
            {
                // Console.WriteLine(curElm.Technology);
                Console.WriteLine(curElm);
            }







        }
    }
}
