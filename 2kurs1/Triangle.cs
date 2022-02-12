using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kurs1
{
    class Triangle
    {
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }

        public Triangle(int _a = 0, int _b = 0, int _c = 0)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public int GetTriangleArea()
        {
            int p = (a + b + c) / 2;

            return (int) Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }

        public bool IsRightTriangle()
        {
            if (a == b & a == c & b == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
