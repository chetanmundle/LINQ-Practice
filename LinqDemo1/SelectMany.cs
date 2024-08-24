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


            foreach(var curElm in methodResult)
            {
                Console.WriteLine(curElm);
            }


        }
    }
}
