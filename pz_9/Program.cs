using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] resultArray = new int[5, 5];

            for (int i = 5, k = 0; i != 0; i--, k++)
            {
                for (int j = 0; j < i; j++)
                {
                    resultArray[k, j + k] = j + 1;
                    resultArray[j + k, k] = j + 1;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(resultArray[i, j] + " ");
                }

                Console.WriteLine();

            }

        }
    }
}
