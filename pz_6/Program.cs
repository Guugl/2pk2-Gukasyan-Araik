using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int variable = int.Parse(Console.ReadLine());
            if (variable % 2 == 0)
            {
                variable++;
            }

            int count = variable;
            while (count < variable*2)
            {

                if (count % 2 != 0)
                {
                    result += count;
                }

                count++;
            }

            Console.WriteLine(result);

            int ppp = -3;

            do
            {
                Console.WriteLine(ppp);
                ppp += 2;
            } while (ppp < 10);

            

        }
    }
}
