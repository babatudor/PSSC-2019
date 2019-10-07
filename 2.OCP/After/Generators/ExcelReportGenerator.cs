using System;

namespace After
{
    public class ExcelReportGenerator: ReportGenerator
    {
        public override void GenerateReport (string text) 
        {
            Console.WriteLine($"Generated Excel report... {text}");
        }
    }
}