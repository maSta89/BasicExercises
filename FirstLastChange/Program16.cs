using System;

namespace FirstLastChange {
    class Program16 {
        static void Main(string[] args) {
            //Write a C# program to create a new string from a given string where the first and last characters will change their positions.

            Console.WriteLine("Write your world");
            string word = Console.ReadLine();

            char firstcharac = word[0];
            char lastcharac = word[word.Length-1];

            char[] ArrayWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++) {
                ArrayWord[i] = word[i];
            }

            ArrayWord[0] = lastcharac;
            ArrayWord[word.Length-1] = firstcharac;

            Console.WriteLine(ArrayWord);
        }
    }
}
