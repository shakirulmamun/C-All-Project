using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICalculation
{
    class Circle
    {
        int radious;
        public Circle()     //constructor, and it has no return type
        {
           
            radious = 10;   
        }
        public Circle(int intialRadius)     //Constructor Overloading
        {
            radious = intialRadius;
        }
        public double Area()        //Method
        {
            return Math.PI * radious * radious;     //basardho
        }
    }
}
