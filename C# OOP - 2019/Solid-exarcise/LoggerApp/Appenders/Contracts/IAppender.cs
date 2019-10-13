namespace LoggerApp.Appenders.Contracts
{
    using Loggers.Enums;

    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);

        ReportLevel ReportLevel {get; set;}
    }
}
