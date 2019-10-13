namespace LoggerApp.Appenders
{
    using System;
    using Layouts.Contacts;
    using Loggers.Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
            this.MessageAppendCount = 0;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessageAppendCount++;
            }
        }
        
    }
}
