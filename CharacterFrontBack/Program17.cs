using System;

namespace _17.CharacterFrontBack {
    class Program17 {
        static void Main(string[] args) {
            //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.

            Console.WriteLine("Write your sentence from one character to multiple words.");
            string word = Console.ReadLine();

            char firstLastChar = word[0];

            Console.WriteLine(firstLastChar+word+firstLastChar);
        }
    }
}
