using System;

namespace _40.CheckNearestValue {
    class Program40 {
        static void Main(string[] args) {
            //Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.

            Console.WriteLine("input first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input second number");
            int num2 = int.Parse(Console.ReadLine());

            int delta1 = Math.Abs(num1 - 20);
            int delta2 = Math.Abs(num2 - 20);


            if (delta1 < delta2) {
                Console.WriteLine($"number {num1} is closest to value 20 ");
            }
            else if (delta1 > delta2) {
                Console.WriteLine($"number {num2} is closest to value 20 ");
            }
            else {
                Console.WriteLine("0 if differences are same");
            }

        }
    }
}
