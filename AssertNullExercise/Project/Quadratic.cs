using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Project
{
    public class Quadratic
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Quadratic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Roots(ref double a, ref double b)
        {
            a = (-B + Math.Sqrt(Discriminant())) / (2 * A);
            b = (-B - Math.Sqrt(Discriminant())) / (2 * A);
        }

        public bool IsRealRoots()
        {
            if (Discriminant() < 0)
            {
                return true;
            }
            return false;
        }

        private double Discriminant()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }
    }
}
