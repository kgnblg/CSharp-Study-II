using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _143311009
{
    class Complex
    {
        double gercek;
        double sanal;

        public Complex(double a, double b)
        {
            gercek = a;
            sanal = b;
        }

        public double Gercek
        {
            get
            {
                return gercek;
            }

            set
            {
                gercek = value;
            }
        }

        public double Sanal
        {
            get
            {
                return sanal;
            }

            set
            {
                sanal = value;
            }
        }

        public static Complex operator true(Complex c1, Complex c2)
        {
            return new Complex();
        }

        public static Complex operator false(Complex c1, Complex c2)
        {
            return new Complex();
        }

        public static Complex operator &(Complex c1, Complex c2)
        {
            double p1 = c1.gercek&c2.gercek;

        }
    }
}
