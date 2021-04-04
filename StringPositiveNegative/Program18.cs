using System;

namespace StringPositiveNegative {
    class Program18 {
        static void Main(string[] args) {//Write a C# program to check two given integers and return true if one is negative and one is positive.

            Console.WriteLine("enter first number positive or negative");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter first number positive or negative");
            int number2 = int.Parse(Console.ReadLine());

            if((number1 > 0 && number2 < 0) || (number1 < 0 && number2 > 0)) {
                Console.WriteLine("It is true that one of number is positive and other negative");
            }
            else {
                Console.WriteLine("numbers do not fall into given limit");
            }
        }
    }
}
