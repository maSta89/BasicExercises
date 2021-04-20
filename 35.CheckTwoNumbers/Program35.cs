using System;

namespace _35.CheckTwoNumbers {
    class Program35 {
        static void Main(string[] args) {
            //Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.

            Console.WriteLine("This program chceks if one of your inputs is lesser then 100 and second is greater then 200.");

            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());


            if (number1 < 100) {
                if (number2 > 200) {
                    Console.WriteLine("first input is lesser then 100 and second is greater then 200");
                }
                else if (number2 < 200) {
                    Console.WriteLine("first input meet the conditions but second does not");
                }
            }
            else if (number2 < 100) {
                if (number1 > 200) {
                    Console.WriteLine("first input is lesser then 100 and second is greater then 200");
                }
                else if (number1 < 200) {
                    Console.WriteLine("one of your input meet the conditions but second does not");
                }
            }
            else {
                Console.WriteLine("neither of your input met the conditions");
            }
        }
    }
}
