using System;
using System.Threading;

namespace AOC20221Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Adam\source\repos\AOC2021\AOC20221Day2\day2.txt");

            // part 1
            /* int hor = 0;
             int depth = 0;
             for (int i = 0; i < lines.Length; i++)
             {
                 string[] dir = lines[i].Split(null);
                 if (dir[0].Equals("forward"))
                 {
                     int move = Int32.Parse(dir[1]);
                     hor += move;
                 }
                 else if (dir[0].Equals("down"))
                 {
                     int move = Int32.Parse(dir[1]);
                     depth += move;
                 }
                 else if (dir[0].Equals("up"))
                 {
                     int move = Int32.Parse(dir[1]);
                     depth -= move;
                 }

             }
             Console.WriteLine(hor+"+"+depth+"="+(depth*hor));*/

            //Part2
            long hor = 0;
            long depth = 0;
            long aim = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] dir = lines[i].Split(null);
                if (dir[0].Equals("forward"))
                {
                    int move = Int32.Parse(dir[1]);
                    hor += move;
                    Console.WriteLine(hor);
                    depth = depth + ( move * aim);
                    Console.WriteLine(depth);
                }
                else if (dir[0].Equals("down"))
                {
                    int move = Int32.Parse(dir[1]);
                    aim += move;
                    Console.WriteLine(aim);
                }
                else if (dir[0].Equals("up"))
                {
                    int move = Int32.Parse(dir[1]);
                    aim -= move;
                    Console.WriteLine(aim);
                }

            }
            Console.WriteLine(depth*hor);

            Thread.Sleep(300);



        }
    }
}
