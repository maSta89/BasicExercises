using System;

namespace _14.ConvertCeltoKeltoFahr {
    class Program14 {
        static void Main(string[] args) {//Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

            Console.Write("enter degrees:");
            double cel = int.Parse(Console.ReadLine());

            double kel = cel + 273.15;
            Console.WriteLine($"Your temperature {cel}°C equals to {kel}°K ");

            double fehr = (cel * 1.8000)+32;
            Console.WriteLine($"Your temperature {cel}°C equals to {fehr}°F ");

        }
    }
}
