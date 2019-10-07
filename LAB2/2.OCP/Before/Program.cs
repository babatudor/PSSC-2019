using System;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open Closed principle");

            ReportGenerator reportGenerator = new ReportGenerator();

            reportGenerator.ReportType = "word";
            reportGenerator.GenerateReport("PSSC test 1");  

            reportGenerator.ReportType = "pdf";
            reportGenerator.GenerateReport("PSSC test 2");       

            reportGenerator.ReportType = "excel";
            reportGenerator.GenerateReport("PSSC test 3");     

            reportGenerator.ReportType = "other";
            reportGenerator.GenerateReport("PSSC test 4");       
        }
    }
}
