using System;
using System.Linq;

namespace pz_8
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] nums = new int[50];
            for (int i = 0; i < 50; i++)
            {
                nums[i] = i;
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            const int step = 15;
            for (int i = 0; i < nums.Length - step; i++)
                nums[i] = nums[i + step];

            for (int i = nums.Length - step; i < nums.Length; i++)
                nums[i] = 0;

            for (int i = 0; i < 50; i++)
                Console.Write(nums[i] + " ");

        }
    }
}
