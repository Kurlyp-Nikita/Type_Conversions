using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    internal class Person

    {
       public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

}
