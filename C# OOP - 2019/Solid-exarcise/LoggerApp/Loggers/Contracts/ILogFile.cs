namespace LoggerApp.Loggers
{
    public interface ILogFile
    {
        void Write(string message);

        long Size { get; }
    }
}
