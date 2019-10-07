using System;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open Closed principle");

            ReportFactory factory = new ReportFactory();
            var excelReport = factory.Create("excel");
            excelReport.GenerateReport("PSSC test 1");

            var wordReport = factory.Create("word");
            wordReport.GenerateReport("PSSC test 2");

            var pdfReport = factory.Create("pdf");
            pdfReport.GenerateReport("PSSC test 3");

            var tdrReport = factory.Create("tdr");
            tdrReport.GenerateReport("PSSC test 4");
        }
    }
}