using System;
using System.Collections.Generic;

namespace LoggingLibrary
{
    public sealed class LogJournal : ILogger
    {
        private static LogJournal _instance = null;
        private static readonly object _lock = new object();
        private List<string> _logs = new List<string>();

        
        private LogJournal() { }

        public static LogJournal Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new LogJournal();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            _logs.Add($"[{DateTime.Now:HH:mm:ss}] {message}");
        }

        public void ShowLogs()
        {
            Console.WriteLine("--- Вміст журналу логів ---");
            _logs.ForEach(Console.WriteLine);
        }
    }
}