namespace LoggerApp.Appenders.Contracts
{
    using Layouts.Contacts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
