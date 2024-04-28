using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    internal class Inploy: Person
    {
        public string Company { get; set; }

        public Inploy(string company, string name) : base(name)
        {
            Company = company;
        }
    }
}
