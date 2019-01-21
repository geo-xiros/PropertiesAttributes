using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Customer
    {
        [FieldInfo("First Name", 30)]
        public string Name { get; set; }
        [FieldInfo("Age", 5)]
        public int Age { get; set; }
        [FieldInfo("Password", 10, true)]
        public string Password { get; set; }

    }
}
