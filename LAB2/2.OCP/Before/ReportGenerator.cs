using System;

namespace Before 
{
    public class ReportGenerator 
    {
        public string ReportType { get; set; }

        public void GenerateReport (string text) 
        {
            if (ReportType.ToUpper().Equals("EXCEL"))
            {
                Console.WriteLine($"Generated {ReportType} report... {text}");
            } 
            else if (ReportType.ToUpper().Equals("PDF"))
            {
                Console.WriteLine($"Generated {ReportType} report... {text}");
            } 
            else if (ReportType.ToUpper().Equals("WORD"))
            {
                Console.WriteLine($"Generated {ReportType} report... {text}");
            }
            else
            {
                Console.WriteLine($"The report type: {ReportType} is unknown. ");
            }
        }
    }
}