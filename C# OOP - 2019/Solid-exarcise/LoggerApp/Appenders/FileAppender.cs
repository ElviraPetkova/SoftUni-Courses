namespace LoggerApp.Appenders
{
    using System;
    using System.IO;
    using Layouts.Contacts;
    using Loggers;
    using Loggers.Enums;

    public class FileAppender : Appender
    {
        private const string Path = @"..\..\..\log.txt";
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            :base(layout)
        {
            this.logFile = logFile;
            this.MessageAppendCount = 0;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) +
                Environment.NewLine;

                File.AppendAllText(Path, content);

                this.MessageAppendCount++;
                this.logFile.Write(content);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
