using System;

namespace TwoNumbersTriple {
    class Program19 {
        static void Main(string[] args) {
            //Write a C# program to compute the sum of two given integers,
            //if two values are equal then return the triple of their sum.

            Console.WriteLine("enter first number positive or negative");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first number positive or negative");
            int number2 = int.Parse(Console.ReadLine());

            int outcome;
            if (number1==number2) {
                outcome = (number1 + number2) * 3;
            }
            else {
                outcome = (number1 + number2);
            }
            Console.WriteLine(outcome);
        }
    }
}
