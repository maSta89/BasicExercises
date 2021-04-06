using System;

namespace _8.MultiplicationTable {
    class Program8 {
        static void Main(string[] args) { //Write a C# Sharp program that takes a number as input and print its multiplication table.

            Console.WriteLine("enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(number1*i);
            }
        }
    }
}
