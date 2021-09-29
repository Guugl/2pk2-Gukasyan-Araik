using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //для 2 задания
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Задание №1");
            for (int i = 20; i <= 70; i += 4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("Задание №2");
            for (int j = 10; j < 16; j++)
            {
                Console.WriteLine(letters[j]);
            }
            Console.WriteLine();

            Console.WriteLine("Задание №3");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("###");
            }
            Console.WriteLine();

            Console.WriteLine("Задание №4");
            for (int j = 0; j <= 100; j++)
            {
                if (j % 10 == 0)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Задание №5");
            for (int i = 4, j = 40; i - j != 42; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
