using System;

namespace NumberRepetition {
    class Program12 {
        static void Main(string[] args) {
            //Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
            //and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

            Console.Write("enter number:");
            int x = int.Parse(Console.ReadLine());

            int p=0;
            do {
                string row1 = "";
                for (int i = 0; i <= 3; i++) {
                    row1 = row1 + x + " ";
                }
                Console.WriteLine(row1);

                string row2 = "";
                for (int i = 0; i < 4; i++) {
                    row2 = row2 + x;
                }
                Console.WriteLine(row2);

                p++;
            } while (p != 2);
        }
    }
}
