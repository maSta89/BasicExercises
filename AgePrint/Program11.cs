using System;

namespace _11.AgePrint {
    class Program11 {
        static void Main(string[] args) {//Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".

            Console.WriteLine("Insert your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");
        }
    }
}
