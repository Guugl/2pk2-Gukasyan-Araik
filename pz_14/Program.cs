using System;
using System.Collections.Generic;
using System.IO;

namespace pz_14
{
    class Program
    {

        const string PATH = @"C:\Users\7\Desktop\res.txt";

        static void Main(string[] args)
        {
            FileStream file = new FileStream(PATH, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string str = reader.ReadToEnd();
            
            List<string> strList = new List<string>();
            strList.AddRange(str.Split("\n"));

            DateTime dtVar = DateTime.Now;

            for (int i = 0; i < strList.Count; i++)
            {
                string item = strList[i];

                if (i == 0)
                {
                    dtVar = DateTime.Parse(item.Split(" ")[0]);
                }
                else
                {
                    if (dtVar > DateTime.Parse(item.Split(" ")[0]))
                    {
                        dtVar = DateTime.Parse(item.Split(" ")[0]);
                    }
                }
            }

            string date;

            if (dtVar.Month > 9)
            {
                date = dtVar.Year + "-" + dtVar.Month + "-" + dtVar.Day;
            } 
            else
            {
                date = dtVar.Year + "-" + "0" + dtVar.Month + "-" + dtVar.Day;
            }


            str = str.Substring(str.IndexOf(date) + date.Length + 1, str.Length - (str.IndexOf(date) + date.Length + 1));
            var lol = str.Split("\n");
            Console.WriteLine(lol[0]);

        }
    }
}
