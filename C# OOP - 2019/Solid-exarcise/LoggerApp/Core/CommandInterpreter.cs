namespace LoggerApp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Appenders;
    using Appenders.Contracts;
    using Core.Contracts;
    using Layouts;
    using Layouts.Contacts;
    using Loggers.Enums;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(params string[] arguments)
        {
            string typeAppender = arguments[0];
            string typeLayout = arguments[1];

            ReportLevel reportLevel = ReportLevel.INFO;

            if(arguments.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(arguments[2]);
            }

            ILayout layout = this.layoutFactory.CreateLayout(typeLayout);

            IAppender appender = this.appenderFactory.CreateAppender(typeAppender, layout);

            appender.ReportLevel = reportLevel;

            appenders.Add(appender);
        }

        public void AddReport(params string[] arguments)
        {
            string reportType = arguments[0];
            string dateTime = arguments[1];
            string message = arguments[2];

            ReportLevel reportLevel = Enum.Parse<ReportLevel>(reportType);

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Logger info");

            foreach (var appender in appenders)
            {
                stringBuilder.AppendLine(appender.ToString());
            }

            Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }
    }
}
