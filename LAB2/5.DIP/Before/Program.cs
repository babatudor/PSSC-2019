using System;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle");

            Logger logger = new Logger();
            logger.Log("PSSC log test");
        }
    }
}
