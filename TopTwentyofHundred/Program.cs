using System;

namespace TopTwentyofHundred {
    class Program {
        static void Main(string[] args) {//Write a C# program to check if an given integer is within 20 of 100 or 200.

            Console.WriteLine("enter positive number"); //for future modification change to "and negative"!!!
            int number1 = int.Parse(Console.ReadLine());

            if ((number1-100)<=20 || (number1-200)<=20 ) {

            }


        //    Console.WriteLine("\nInput an integer:"); //solution from web https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-22.php
        //    int x = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(result(x));
        //}

        //public static bool result(int n) {
        //    if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
        //        return true;
        //    return false;
        //}

    }
    } 
    
}
