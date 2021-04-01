using System;

namespace MultiplicationThreeNumbers {
    class Program6 {
        static void Main(string[] args) { // Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

            Console.WriteLine("enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter third number:");
            int number3 = int.Parse(Console.ReadLine());

            int mult;
            mult = number1 * number2 * number3;

            Console.WriteLine($"Multiplication of these three numbers {number1} ,{number2} and {number3} equals to: {mult}");
        }
    }
}
