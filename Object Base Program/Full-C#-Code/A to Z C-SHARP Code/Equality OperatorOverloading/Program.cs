using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_OperatorOverloading
{
    class ch03_14
    {
        public static void Main()
        {
            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(3, 4);

            System.Console.WriteLine("complex1 = {0}", complex1);
            System.Console.WriteLine("complex2 = {0}", complex2);

            Complex complex3 = -complex1;
            System.Console.WriteLine("-complex1 = {0}", complex3);

            System.Console.WriteLine("complex1 + complex2 = {0}",
             complex1 + complex2);

            if (complex1 == complex2)
            {
                System.Console.WriteLine("complex1 equals complex2");
            }
            else
            {
                System.Console.WriteLine("complex1 does not equal complex2");
            }
            Console.ReadKey();
        }
    }

    public struct Complex
    {
        public int real;
        public int imaginary;

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            if (imaginary >= 0)
            {
                return (System.String.Format("{0} + {1}i", real, imaginary));
            }
            else
            {
                return (System.String.Format("{0} - {1}i", real,
                System.Math.Abs(imaginary)));
            }
        }

        public static Complex operator -(Complex complex)
        {
            return new Complex(-complex.real, -complex.imaginary);
        }

        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex(complex1.real + complex2.real,
             complex1.imaginary + complex2.imaginary);
        }

        public static implicit operator Complex(int theInt)
        {
            return new Complex(theInt, 0);
        }

        public static explicit operator int(Complex complex)
        {
            return complex.real;
        }

        public static bool operator ==(Complex complex1, Complex complex2)
        {
            if (complex1.real == complex2.real && complex1.imaginary == complex2.imaginary)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Complex complex1, Complex complex2)
        {
            return !(complex1 == complex2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Complex))
            {
                return false;
            }
            return this == (Complex)obj;
        }

        public override int GetHashCode()
        {
            return (int)System.Math.Sqrt(real * real +
             imaginary * imaginary);
        }
        
    }
    
}