using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    internal class Client: Person
    {
        public string Bank { get; set; }

        public Client(string bank, string name) : base(name)
        {
            Bank = bank;
        }
    }
}
