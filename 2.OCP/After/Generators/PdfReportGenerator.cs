using System;

namespace After
{
    public class PdfReportGenerator : ReportGenerator
    {
        public override void GenerateReport (string text) 
        {
            Console.WriteLine($"Generated PDF report... {text}");
        }
    }
}