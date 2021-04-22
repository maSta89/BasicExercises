using System;
using System.Collections.Generic;

namespace _39.FindLargestLowest {
    class Program39 {
        static void Main(string[] args) {
            //Write a C# program to find the largest and lowest values from three integer values

            Console.WriteLine("Input three numbers");

            List<int> Numlist = new List<int>();

            Console.WriteLine("first");
            Numlist.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("second");
            Numlist.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("third");
            Numlist.Add(int.Parse(Console.ReadLine()));

            Numlist.Sort();

            int [] numarray =  Numlist.ToArray();

            Console.WriteLine("lowest number is = " + numarray.GetValue(0));

            Console.WriteLine("largest number is = " + numarray.GetValue(numarray.Length-1));

        }
    }
}
