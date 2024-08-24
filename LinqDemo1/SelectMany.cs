using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class SelectMany
    {
        public void SelectManyMethod()
        {
            List<string> strList = new List<string>() { "Chetan", "Kaushik" };

            var methodResult = strList.SelectMany(x=>x).ToList();                                        // OR

            var queryResult = from record in strList
                              from ch in record 
                              select ch;


            foreach(var curElm in queryResult)
            {
                Console.WriteLine(curElm);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");

            List<Employee1> employee1s = new List<Employee1>()
            {
                new Employee1(){Id = 1, Name="Chean", Email="Chetan@gmail.com", Pragramming = new List<string>{ "PHP","JAVA","Python"} },
                new Employee1(){Id = 2, Name="Ramesh", Email="Chetan@gmail.com", Pragramming = new List<string>{ "C#","Ruby","C"} },
                new Employee1(){Id = 3, Name="Rahul", Email="Chetan@gmail.com", Pragramming = new List<string>{ "C++","JAVA","Kotlin"} },
                new Employee1(){Id = 4, Name="Kanchan", Email="Chetan@gmail.com", Pragramming = new List<string>{ "CPP","Javascrip","Typescrip"} },
                new Employee1(){Id = 5, Name="Prabha", Email="Chetan@gmail.com", Pragramming = new List<string>{ "Swift","CSS","Html"} },
            };


            var listofLang = employee1s.SelectMany(l => l.Pragramming).ToList();
            foreach(var curElm in listofLang)
            {
                Console.WriteLine(curElm); 
            }

        }
    }
}
