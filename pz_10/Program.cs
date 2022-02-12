using System;
using System.Linq;

namespace pz_10
{
    static class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            var lastItemsArray = new int[5];
            var maxItemsArray = new int[5];







            int[][] nums = new int[5][];

            for (int i = 0; i < 5; i++)
            {

                nums[i] = new int[random.Next(2,15)];

                for (int j = 0; j < nums[i].Length; j++)
                {
                    nums[i][j] = random.Next(100);
                }
            }

            foreach (int[] item in nums)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                lastItemsArray[i] = nums[i][nums[i].Length - 1];
            }

            foreach (var i in lastItemsArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                maxItemsArray[i] = nums[i].Max();
            }

            foreach (var i in maxItemsArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                nums[i].SwapValues(0, Array.IndexOf(nums[i], maxItemsArray[i]));
            }

            foreach (int[] item in nums)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        public static void SwapValues<T>(this T[] source, int index1, int index2)
        {
            T temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }


    }
}
