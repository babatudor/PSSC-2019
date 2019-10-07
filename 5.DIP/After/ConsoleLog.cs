using System;

namespace After
{
    public class ConsoleLog : ILog
    {
        public void Log (string textToLog) 
        {
            Console.WriteLine(textToLog);
        }
    }
}