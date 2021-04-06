using System;

namespace OddNumbersTo99 {
    class Program25 {
        static void Main(string[] args) {
            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

            int nModulo=0;

            for (int i = 1; i < 100; i++) {
                for (int ind = 1; ind <= i; ind++) {
                    if (i%ind == 0) {
                        nModulo++;
                    }
                }
                if (nModulo == 2) {
                    Console.WriteLine(i);
                }
                nModulo = 0;
            }
        }
    }
}
