using System;

namespace _2kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(2, 3, 5);
            Triangle tr2 = new Triangle(5, 5, 5);
            Triangle tr3 = new Triangle(7, 3, 1);
            Triangle tr4 = new Triangle(1, 4, 7);

            if (tr1.IsRightTriangle())
            {
                Console.WriteLine("tr1 правильный");
            }
            else
            {
                Console.WriteLine("tr1 не правильный");
            }

            if (tr2.IsRightTriangle())
            {
                Console.WriteLine("tr2 правильный");
            }
            else
            { 
                Console.WriteLine("tr2 не правильный");
            }

            if (tr3.IsRightTriangle())
            {
                Console.WriteLine("tr3 правильный");
            }
            else
            {
                Console.WriteLine("tr3 не правильный");
            }

            if (tr4.IsRightTriangle())
            {
                Console.WriteLine("tr4 правильный");
            }
            else
            {
                Console.WriteLine("tr4 не правильный");
            }

            Console.WriteLine($"Площадь tr1 = {tr1.GetTriangleArea()}");
            Console.WriteLine($"Площадь tr2 = {tr2.GetTriangleArea()}");
            Console.WriteLine($"Площадь tr3 = {tr3.GetTriangleArea()}");
            Console.WriteLine($"Площадь tr4 = {tr4.GetTriangleArea()}");

        }

    }
}
