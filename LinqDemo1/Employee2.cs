using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class Employee2
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<Techs> Programming {  get; set; }

    }


    public class Techs
    {
        public string Technology { get; set; }
    }
}
