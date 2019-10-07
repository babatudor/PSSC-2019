using System.IO;

namespace After
{
    public class FileLog : ILog
    {
        public void Log (string textToLog) 
        {
            using (StreamWriter writer = System.IO.File.AppendText("logfile.txt"))
            {
                writer.WriteLine(textToLog);
            }
        }
    }
}