using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp.Models
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Skills { get; set; }
    }
}
