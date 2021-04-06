using System;

namespace _27.SumDigitsInteger {
    class Program27 {
        static void Main(string[] args) {
            //Write a C# program and compute the sum of the digits of an integer.

            Console.WriteLine("insert number");
            string textNumber = Console.ReadLine();

            string[] retezec = new string[textNumber.Length];


            for (int i = 0; i < textNumber.Length; i++) {
                retezec[i] = textNumber.Substring(i, 1);
            }

            int numero;
            int sum = 0;
            for (int i = 0; i < retezec.Length; i++) {
                int.TryParse(retezec[i], out numero);
                sum = sum + numero;
            }

            Console.WriteLine(sum);

        }
    }
}
