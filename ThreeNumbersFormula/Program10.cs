using System;

namespace _10.ThreeNumbersFormula {
    class Program10 {
        static void Main(string[] args) {//Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.

            Console.WriteLine("enter x number:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("enter y number:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("enter z number:");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine($"first formula (x+y)*z = {(x+y)*z}");

            Console.WriteLine($"second formula x*y + y*z = {x * y + y * z}");

        }
    }
}
