// File: Program.cs
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
            Console.WriteLine("Введіть ціле число:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Ви ввели число {number}");
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне ціле число.");
            }
            }
        }
    }
}
