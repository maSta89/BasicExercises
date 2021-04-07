using System;
using System.IO;

namespace _29.FileSizebytes {
    class Program29 {
        static void Main(string[] args) {//Write a C# program to find the size of a specified file in bytes.

            FileInfo file = new FileInfo(@"D:\programovani kurz\cviceniw3resource\BasicExercises\FileSizebytes\Files\File1.txt"); //File is attachted to project
            Console.WriteLine("File size is: "+ file.Length.ToString() + " byte");
        }
    }
}
