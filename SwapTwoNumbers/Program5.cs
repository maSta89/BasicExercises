using System;

namespace SwapTwoNumbers_ {
    class Program5 {
        static void Main(string[] args) { //Write a C# Sharp program to swap two numbers.

            int midstep;

            Console.WriteLine("enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("first number: "+number1);
            Console.WriteLine("second number: "+number2);

            Console.WriteLine("Swaped:");

            midstep = number1;
            number1 = number2;
            number2 = midstep;

            Console.WriteLine("first number: " + number1);
            Console.WriteLine("second number: " + number2);


        }
    }
}
