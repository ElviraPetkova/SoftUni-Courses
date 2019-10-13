namespace LoggerApp.Appenders
{
    using Appenders.Contracts;
    using Layouts.Contacts;
    using Loggers.Enums;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        protected ILayout Layout { get; }

        protected int MessageAppendCount { get;  set; }

        public ReportLevel ReportLevel { get; set ; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            string resultString = $"Appender type: {this.GetType().Name}, " +
                $"Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel}, " +
                $"Messages appended: {this.MessageAppendCount}";

            return resultString;
        }
    }
}
