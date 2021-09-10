using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_C_Sharp
{
    public abstract class Person
    {
        internal string firstName = string.Empty;
        internal string lastName = string.Empty;
        internal DateTime DateOfBirth;
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime dateofBirth { get; set; }
        public abstract string GetFullName();
        public abstract string GetAge();

    }
}
