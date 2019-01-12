using System;
using System.Collections.Generic;

// https://www.lynda.com/Xamarin-tutorials/New-Features-Xamarin-Visual-Studio-2017/601790-2.html
namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTuple = Tuple.Create(1, "hello", true);
            Console.WriteLine(myTuple.Item2);

            foreach (var info in GetInfo())
            {
                Console.WriteLine($"Year: {info.Year}, Make: {info.Make}");
            }

            Console.ReadKey();
        }

        private static List<(int Year, string Make)> GetInfo()
        {
            var returnList = new List<(int, string)>();

            returnList.Add((1990, "a"));
            returnList.Add((2000, "b"));
            returnList.Add((2010, "c"));
            returnList.Add((2020, "d"));

            return returnList;
        }
    }
}
