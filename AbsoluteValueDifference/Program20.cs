using System;

namespace _20.AbsoluteValueDifference {
    class Program20 {
        static void Main(string[] args) {
            //Write a C# program to get the absolute value of the difference between two given numbers.
            //Return double the absolute value of the difference if the first number is greater than second number.

            Console.WriteLine("enter first number positive or negative");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first number positive or negative");
            int number2 = int.Parse(Console.ReadLine());

            int difference;

            difference = number1 - number2;

            if (number1 < number2) {
                Console.WriteLine(Math.Abs(difference));
            }
            else if (number1 > number2) {
                Console.WriteLine(Math.Abs(difference*2));
            }
            else {
                Console.WriteLine("numbers are equal");
            }
        }
    }
}
