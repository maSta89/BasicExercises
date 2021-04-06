using System;

namespace _21.TrueIfTwenty {
    class Program21 {
        static void Main(string[] args) {
            //Write a C# program to check the sum of the two given integers and return true
            //if one of the integer is 20 or if their sum is 20.

            Console.WriteLine("enter first number positive or negative");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number positive or negative");
            int number2 = int.Parse(Console.ReadLine());

            int sum;
            sum = number1 + number2;

            if (number1==20 || number2==20 || sum==20) {
                Console.WriteLine($"one of given values is equal to 20 sum = {sum}");
            }
            else {
                Console.WriteLine($"none of the given values is equal to 20, sum = {sum}");
            }

            
        }
    }
}
