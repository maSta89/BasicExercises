using System;

namespace _41.StringContainsW {
    class Program {
        static void Main(string[] args) {
            //Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.

            Console.WriteLine("Enter word with or without 'w'");
            string word = Console.ReadLine();

            int wCounter=0;

            for (int i = 0; i < word.Length; i++) {
                if (word[i] == 'w') {
                    wCounter++;
                }
            }

            if ((wCounter >= 1) && (wCounter <= 3)) {
                Console.WriteLine($"given word contains {wCounter} letter 'w' ");
            }
            else {
                Console.WriteLine("Given word do not contain required number of 'w'character");
            }
            

        }
    }
}
