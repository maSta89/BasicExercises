using System;

namespace _36.IntegerInRange {
    class Program36 {
        static void Main(string[] args) {
            //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

            Console.WriteLine("Enter whole number");
            int number = int.Parse(Console.ReadLine());

            if (-10 <= number && number <= 10) {
                Console.WriteLine($"number {number} is between -10 and 10");
            }
            else {
                Console.WriteLine($"your number {number} is not between -10 and 10");
            }


        }
    }
}
