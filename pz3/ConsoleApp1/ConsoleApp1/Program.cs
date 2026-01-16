using System;
using LoggingLibrary; 

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ILogger myLogger = LogJournal.Instance;

            Console.WriteLine("Демонстрація патерну Singleton");

            myLogger.Log("Перша подія записана.");
            myLogger.Log("Друга подія записана.");

            
            ILogger anotherReference = LogJournal.Instance;
            anotherReference.Log("Запис через інше посилання.");

            
            myLogger.ShowLogs();

            Console.WriteLine("\nНатисніть Enter, щоб вийти...");
            Console.ReadLine();
        }
    }
}