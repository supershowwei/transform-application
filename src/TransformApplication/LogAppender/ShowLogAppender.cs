using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace log4net.Appender
{
    public delegate void ShowLogHandler(Level level, string message);

    public class ShowLogAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            if (ShowLogHandler != null)
            {
                ShowLogHandler(loggingEvent.Level, loggingEvent.RenderedMessage);
            }
        }

        public ShowLogHandler ShowLogHandler
        {
            private get;
            set;
        }
    }
}
