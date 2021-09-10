using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Programs
    {
        string _FirstName;
        string _LastName;
        public Programs(string firstName, string lastName)
        {
            _FirstName = firstName;
            _LastName = lastName;

        }

        public void PrintName()
        {
            Console.WriteLine("FullName: { 0} { 1}", _FirstName, _LastName);
        }
    }
    
}
