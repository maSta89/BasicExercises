using System;

namespace _28.ReverseSentenceWords {
    class Program28 {
        static void Main(string[] args) {//Write a C# program to reverse the words of a sentence.

            Console.WriteLine("Write sentence to reverse");

            string sentence = Console.ReadLine();

            string[] wordsArray = sentence.Split(' ', '.');

            string sentenceRev="";

            for (int i = wordsArray.Length-1; i >= 0; i--) {
                sentenceRev = sentenceRev + wordsArray[i] +" ";
            }

            Console.WriteLine(sentenceRev);

        }
    }
}
