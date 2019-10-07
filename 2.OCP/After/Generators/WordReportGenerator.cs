using System;

namespace After
{
    public class WordReportGenerator : ReportGenerator
    {
        public override void GenerateReport (string text) 
        {
            Console.WriteLine($"Generated Word report... {text}");
        }
    }
}