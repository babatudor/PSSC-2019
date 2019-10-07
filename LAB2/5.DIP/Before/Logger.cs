using System.IO;

namespace Before
{
    public class Logger
    {
        public void Log (string text) 
        {
            using (StreamWriter writer = System.IO.File.AppendText("logfile.txt"))
            {
                writer.WriteLine(text);
            }
        }
    }
}