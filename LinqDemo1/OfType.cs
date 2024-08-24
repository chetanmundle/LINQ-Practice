using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class OfType
    {
        public void OfTypeMethod()
        {
            var dataSource = new List<object>() { "Chetan","Ramesh","Lokesh",2,3,4,5,6 };

            var methodSyntax = dataSource.OfType<string>().ToList();                                            // OR

            var querySyntax = (from name in dataSource
                              where name is int
                              select name).ToList();

            foreach(var curElm in querySyntax)
            {
                Console.WriteLine(curElm);
            }

        }
    }
}
