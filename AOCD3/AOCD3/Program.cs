using System;
using System.Collections.Generic;

namespace AOCD3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Adam\source\repos\AOC2021\AOCD3\AOCD3\day3.txt");
            //part 1
            /*List<string> gama = new List<string>();
             List<string> epsilon = new List<string>();
             int oneCount = 0;
             int zeroCount = 0;
             for (int i = 0; i < 12; i++)
             {               

                 for (int j = 0; j < lines.Length; j++)
                 {
                     string bin = lines[j];

                     if (bin[i].Equals('1'))
                     {
                         oneCount++;
                     }
                     else
                     {
                         zeroCount++;

                     }


                 }
                 if (oneCount>zeroCount)
                 {
                     gama.Add("1");
                     epsilon.Add("0");
                 }
                 else
                 {
                     gama.Add("0");
                     epsilon.Add("1");
                 }

                 oneCount = 0;
                 zeroCount = 0;

             }
             string gamaString = string.Join(",", gama);
             string epString = string.Join(",", epsilon);

             Console.WriteLine(gamaString);
             Console.WriteLine(epString);*/
            //part2
            
            List<string> ox = new List<string>();
            List<string> co2 = new List<string>();
            List<string> temp = new List<string>();
            List<string> tempTwo = new List<string>();
            foreach (var item in lines)
            {
                ox.Add(item);
                co2.Add(item);
            }
                                            
         
            static void OxyGenRate(List<string> list, int range, List<string> temp )
            {
                int oneCount = 0;
                int zeroCount = 0;
                for (int i = 0; i < range; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {

                        string bin = list[j];
                        if (bin[i].Equals('1'))
                        {

                            oneCount++;
                        }
                        else
                        {
                            zeroCount++;

                        }


                    }
                    if (oneCount >= zeroCount)
                    {

                        foreach (var item in list)
                        {
                            string bin = item;
                            if (bin[i].Equals('0'))
                            {

                                temp.Add(item);
                            }
                        }
                        foreach (var item in temp)
                        {
                            list.Remove(item);
                        }
                        temp.Clear();
                    }
                    else
                    {

                        foreach (var item in list)
                        {
                            string bin = item;
                            if (bin[i].Equals('1'))
                            {

                                temp.Add(item);
                            }
                        }

                        foreach (var item in temp)
                        {
                            list.Remove(item);
                        }
                        temp.Clear();
                    }
                    oneCount = 0;
                    zeroCount = 0;


                }
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            static void CO2ScrubRate(List<string> list, int range, List<string> temp) 
            {
                int oneCount = 0;
                int zeroCount = 0;
                for (int i = 0; i < range; i++)
                {
                    foreach (var item in list)
                    {
                        string binary = item;

                        if (binary[i].Equals('1'))
                        {
                            oneCount++;
                        }
                        else
                        {
                            zeroCount++;
                        }

                    }
                    if (oneCount == zeroCount && list.Count == 2)
                    {

                        foreach (var item in list)
                        {
                            string binTwo = item;
                            if (binTwo[i].Equals('1'))
                            {

                                temp.Add(item);
                            }
                        }
                        foreach (var item in temp)
                        {
                            list.Remove(item);
                        }
                        temp.Clear();
                        break;

                    }
                    else
                    {
                        if (oneCount > zeroCount)
                        {

                            foreach (var item in list)
                            {
                                string binOne = item;
                                if (binOne[i].Equals('1'))
                                {

                                    temp.Add(item);
                                }
                            }
                            foreach (var item in temp)
                            {
                                list.Remove(item);
                            }
                            temp.Clear();
                        }
                        else
                        {

                            foreach (var item in list)
                            {
                                string binTwo = item;
                                if (binTwo[i].Equals('0'))
                                {

                                    temp.Add(item);
                                }
                            }
                            foreach (var item in temp)
                            {
                                list.Remove(item);
                            }
                            temp.Clear();
                        }
                    }
                    oneCount = 0;
                    zeroCount = 0;
                   

                }
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            OxyGenRate(ox, 12, temp);
            Console.WriteLine("\n");
            CO2ScrubRate(co2, 12, tempTwo);






        }
    }
}
