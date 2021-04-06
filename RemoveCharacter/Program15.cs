using System;

namespace _15.RemoveCharacter {
    class Program15 {
        static void Main(string[] args) {//Write a C# program remove specified a character from a non-empty string using index of a character

            Console.WriteLine("Write your world");
            string word = Console.ReadLine();

            Console.WriteLine("choose character you want to remove");
            string character = Console.ReadLine();

            string empty = "";
            Console.WriteLine(word.Replace(character, empty));
        }
    }
}
