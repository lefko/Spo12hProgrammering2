using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise10.Interfaces;

namespace Spo12h.Progr2.Exercise10.Classes
{
    class LoggApplication
    {
        private ILogger log;
        
        public LoggApplication(ILogger log )
        {
            this.log = log;
        }

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Add message to log");
                Console.WriteLine("2. Print log");
                Console.WriteLine();
                Console.Write("Choice: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case"0":
                        isRunning = false;
                        break;
                    case "1":
                        MessageToAdd();
                        break;
                    case "2": 
                        PrintLogs();
                        break;
                }
            }  
        }

        private void MessageToAdd()
        {
            Console.Write("Enter log message: ");
            string msg = Console.ReadLine();
            log.Log(msg);
        }

        private void PrintLogs()
        {
            var logPosts = log.LogPosts;
            foreach (string logPost in logPosts)
            {
                Console.WriteLine(logPost);
            }

            Console.WriteLine();
        }
    }
}
