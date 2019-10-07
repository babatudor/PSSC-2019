using System;

namespace After
{
    public class UnknownReportGenerator : ReportGenerator
    {
        public override void GenerateReport (string text) 
        {
            Console.WriteLine("The report type is unknown.");
        }
    }
}