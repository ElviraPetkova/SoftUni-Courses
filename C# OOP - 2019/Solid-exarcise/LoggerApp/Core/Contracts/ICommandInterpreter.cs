namespace LoggerApp.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(params string[] arguments);

        void AddReport(params string[] arguments);

        void PrintInfo();
    }
}
