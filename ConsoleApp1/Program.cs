using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Adam\source\repos\AOC2021\ConsoleApp1\day1.txt");
            int[] ints = Array.ConvertAll(lines, s => int.Parse(s));
            //part 1
            /* int first = ints[0];
             int count = 0;
             for (int i = 0; i < lines.Length; i++)
             {
                 if (first < ints[i])
                 {
                     count++;
                     first = ints[i];
                 }
                 else { first = ints[i]; }
             }
             Console.WriteLine(count);*/
            //part2
            List<int> sums = new List<int>();
            int count = 0;
            int first = ints[0] + ints[1] + ints[2];
            for (int i = 0; i < ints.Length; i++)
            {
                if ((i+2)<ints.Length)
                {
                    sums.Add(ints[i] + ints[i + 1] + ints[i + 2]);
                }
                else
                {
                    break; 
                }
            }
            foreach (var item in sums)
            {
                if (first<item)
                {
                    count++;
                    first = item;
                }
                else { first = item; }
            }
            Console.WriteLine(count);
        }
    }
}
