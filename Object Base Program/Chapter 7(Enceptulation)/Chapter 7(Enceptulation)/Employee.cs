using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Enceptulation_
{
    class Employee
    {
        private int exprience;      //exprience is field
        private double salary;      //salary is field.................

        public int getexp()         //getexp is method
        {
            return exprience;
        }
        public void setexp(int val)     //setexp is method
        {
            exprience = val;
        }
        public double Salary            //Salary is Property
        {
            get { return salary;}       //get is method...................
            set { salary = value;}      //set is method
        }
    }
}
