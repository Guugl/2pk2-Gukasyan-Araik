using Org.BouncyCastle.Utilities;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            string[] aa = a.Split(". ");
            string[][] aaa = new string[aa.Length][];
            int[] l = new int[aa.Length];

            for (int i = 0; i < aa.Length; i++)
            {
                aaa[i] = aa[i].Split(" ");
                l[i] = aaa[i].Length;
            }

            Array.Sort(aaa);

            foreach (var item in aaa)
            {
                Arrays.sort(ite, (x, y)->x.split(" ").length - y.split(" ").length);
            }

            /*for (int i = 0; i < aaa.Length; i++)
            {
                for (int i1 = 0; i1 < aaa.Length; i1++)
                {
                    string[] item = aaa[i1];
                    if (item.Length == i)
                    {
                        foreach (var it in item)
                        {
                            Console.Write(it + " ");
                        }
                    }
                }
            }

            foreach (var it in aaa[aaa.Length-1])
            {
                Console.Write(it + " ");
            }*/

        }
    }
}
