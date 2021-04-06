using System;

namespace _24.LongestWord {
    class Program24 {
        static void Main(string[] args) {//Write a C# program to find the longest word in a string.

            Console.WriteLine("Write sentence with multiple words");
            string sentence = Console.ReadLine();

            String[] words = sentence.Split(' ', '.', ',');

            int maxlenght = 0;

            string longest = "";

            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length > maxlenght) {
                    maxlenght = words[i].Length;
                    longest = words[i];
                }
            }

            Console.WriteLine(longest);

        }
    }
}
