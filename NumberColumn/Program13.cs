using System;

namespace NumberColumn {
    class Program13 {
        static void Main(string[] args) {
            //Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

            Console.Write("enter number:");
            int x = int.Parse(Console.ReadLine());

            string row = "";
            for (int s = 0; s < 3; s++) {
                row = row + x;
            }

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(row);
            }
        }
    }
}
