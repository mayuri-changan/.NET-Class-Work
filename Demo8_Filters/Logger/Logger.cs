

namespace _08Demo_Filters_Session.Loggers
{
    public class Logger
    {
        private static readonly Logger _logger = new Logger();
        private Logger()
        {

        }

        public static Logger CurrentLogger
        {
            get { return _logger; }
        }

        public void Log(string message)
        {
            string filePath = @"C:\Users\mayur\Desktop\.NET\.NET_MVC_WebServer\Demo8_Filters\FileLogs\applog.txt";

            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.Write($"Logged at {DateTime.Now.ToString()}: {message}");

            writer.Close();
            fs.Close();

            writer = null;
            fs = null;
        }
    }
}
