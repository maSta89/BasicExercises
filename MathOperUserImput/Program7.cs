using System;

namespace MathOperUserImput {
    class Program7 {
        static void Main(string[] args) {
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers
            //which will be entered by the user.

            Console.WriteLine("enter first number:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Result for adding two number {number1} and {number2} equals {number1+number2}");

            Console.WriteLine($"Result for subtracting two number {number1} and {number2} equals {number1 - number2}");

            Console.WriteLine($"Result for multiplying two number {number1} and {number2} equals {number1 * number2}");

            Console.WriteLine($"Result for dividing two number {number1} and {number2} equals {number1 / number2}");
        }
    }
}
