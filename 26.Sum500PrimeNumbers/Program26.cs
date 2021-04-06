using System;

namespace _26.Sum500PrimeNumbers {
    class Program26 {
        static void Main(string[] args) {
            //Write a C# program to compute the sum of the first 500 prime numbers.

            int nModulo = 0;
            int sum = 0;

            int alfa = 1;

            int primeN=0;
            for (int i = 1; i <= alfa; i++) {

                alfa++;

                for (int ind = 1; ind <= i; ind++) {
                    if (i % ind == 0) {
                        nModulo++;
                    }
                }
                if (nModulo == 2) {
                    sum = sum + i;
                    primeN++;
                    //Console.WriteLine(i);
                }
                nModulo = 0;
                if (primeN == 500) {
                    break;
                }


            }

            Console.WriteLine(sum);

        }
    }
}
