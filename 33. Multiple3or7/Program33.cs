using System;

namespace _33._Multiple3or7 {
    class Program33 {
        static void Main(string[] args) {
            //Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.

            Console.WriteLine("write a positive number" );
            int number = int.Parse(Console.ReadLine());

            if ((number % 3) == 0 && (number % 7) == 0) {
                Console.WriteLine("number is multiple of 3 and 7");
            }
            else if ((number % 3) == 0 && number !=0) {
                Console.WriteLine("number is multiple of 3");
            }
            else if ((number % 7)  == 0 && number != 0) {
                Console.WriteLine("number is multiple of 7");
            }
            else {
                Console.WriteLine("number is not multiple of 3 or 7");
            }
        }
    }
}
