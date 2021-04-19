using System;

namespace _30.ConvertHexDec {
    class Program {
        static void Main(string[] args) {
            //Write a C# program to convert a hexadecimal number to decimal number.

            Console.WriteLine("write hexidecimal number");
            string strhex = Console.ReadLine();
            int hex = Convert.ToInt32(strhex, 16);
            Console.WriteLine(hex);
        }
    }
}
