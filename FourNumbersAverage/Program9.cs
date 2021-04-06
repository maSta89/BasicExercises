using System;

namespace _9.FourNumbersAverage {
    class Program9 {
        static void Main(string[] args) { // Write a C# Sharp program that takes four numbers as input to calculate and print the average.

            int[] Arraynumber = new int[4];

            double sum = 0;

            for (int i = 0; i < Arraynumber.Length; i++) {

                Console.WriteLine("insert number: " + (i + 1));
                Arraynumber[i] = int.Parse(Console.ReadLine());
                sum = sum + Arraynumber[i];
            }

            double avg;
            avg = sum / Arraynumber.Length;

            Console.WriteLine("average for your numbers equals to: "+avg);
        }
    }
}
