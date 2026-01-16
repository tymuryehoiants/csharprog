using System;
using ComplexLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Complex c1 = new Complex(4, 3);
            Complex c2 = new Complex(1, 2);

            Console.WriteLine("--- Тест комплексних чисел ---");
            Console.WriteLine($"Число 1: {c1}");
            Console.WriteLine($"Число 2: {c2}");
            Console.WriteLine($"Сума: {c1 + c2}");
            Console.WriteLine($"Множення c1 на 2.5: {c1 * 2.5}");

            
            Console.WriteLine($"c1 == c2: {c1 == c2}");

            
            if (c1)
                Console.WriteLine("c1 - вірно");

            
            double mod = (double)c1; 
            Complex fromDouble = 10.5; 

            Console.WriteLine($"явне приведення c1 к double (модуль): {mod}");
            Console.WriteLine($"Неявне приведення з 10.5: {fromDouble}");

            Console.WriteLine("\nНатисніть будь-що для виходу...");
            Console.ReadKey();
        }
    }
}