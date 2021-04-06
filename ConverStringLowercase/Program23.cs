using System;

namespace _23.ConverStringLowercase {
    class Program23 {
        static void Main(string[] args) {//Write a C# program to convert a given string into lowercase.

            Console.WriteLine("Write a word with at least one upper character");
            string word = Console.ReadLine();

            Console.WriteLine($"conversion of your word \n {word} \n is {word.ToLower()}");
        }
    }
}
