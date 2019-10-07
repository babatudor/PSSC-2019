using System;

namespace After
{
    public class ReportFactory
    {
        public ReportGenerator Create(string type)
        {
            if (type.ToLower().Equals("pdf"))
            {
                return new PdfReportGenerator();
            }
            else if (type.ToLower().Equals("excel"))
            {
                return new ExcelReportGenerator();
            }
            else if (type.ToLower().Equals("word"))
            {
                return new WordReportGenerator();
            }

            else return new UnknownReportGenerator();
        }
    }
}