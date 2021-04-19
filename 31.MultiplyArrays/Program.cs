using System;

namespace _31.MultiplyArrays {
    class Program {
        static void Main(string[] args) {
            //Write a C# program to multiply corresponding elements of two arrays of integers.

            int[] array1 = { 1,3,-5,4};
            int[] array2 = { 1,4,-5,-2};

            int multiply;
            string outputmultiply="";

            for (int i = 0; i < array1.Length; i++) {

                multiply= array1[i] * array2[i];
                outputmultiply = outputmultiply + multiply + " ";
            }

            Console.WriteLine(outputmultiply);
        }
    }
}
