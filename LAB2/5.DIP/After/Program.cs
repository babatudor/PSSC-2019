using System;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle");

            var consoleLogger = new Logger(new ConsoleLog());
            consoleLogger.Log("Console log test");

            var fileLogger = new Logger(new FileLog());
            fileLogger.Log("File log test");
        }
    }
}
