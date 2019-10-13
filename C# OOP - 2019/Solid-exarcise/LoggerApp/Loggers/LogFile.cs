namespace LoggerApp.Loggers
{
    using System.Linq;

    public class LogFile : ILogFile
    {
        public long Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
