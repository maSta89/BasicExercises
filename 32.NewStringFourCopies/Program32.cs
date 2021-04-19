using System;

namespace _32.NewStringFourCopies {
    class Program32 {
        static void Main(string[] args) {
            //Write a C# program to create a new string of four copies, taking last four characters from a given string.
            //If the length of the given string is less than 4 return the original one.

            /*test sentence The quick brown fox jumps over the lazy dog.*/

            Console.WriteLine("Write a sentence with multiple words. (make last word less or more then four letters) ");

            string sentence = Console.ReadLine();
            String[] words = sentence.Split(' ', '.', ',');

            if (words[words.Length - 1].Length < 4) {
                Console.WriteLine(sentence);
            }
            else {
                Console.WriteLine(words[words.Length - 1]+" ,"+ words[words.Length - 1] + " ," + words[words.Length - 1] + " ," + words[words.Length - 1]);
            }

        }
    }
}
