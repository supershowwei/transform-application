using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TransformApplication.Utilities
{
    class Optimizer
    {
        private static string CurrentExecutingDirectory
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }

        public static void OptimizeEnvironment(params object[] args)
        {
            // 清除 Log 資料
            ClearLogFiles();
        }

        private static void ClearLogFiles()
        {
            XDocument log4netConfig = XDocument.Load(Path.Combine(CurrentExecutingDirectory, "log4net.config"));
            XElement fileAppenderElement = log4netConfig.Root.Elements("appender").Where(a => a.Attribute("name").Value == "FileAppender").First();
            
            string logDirectory = Path.GetDirectoryName(fileAppenderElement.Element("file").Attribute("value").Value);
            DateTime deadline = DateTime.Now.AddMonths(-1).Date;

            try
            {
                Directory.GetFiles(logDirectory, string.Format("{0}*{1}*.*", Assembly.GetExecutingAssembly().GetName().Name, Environment.MachineName))
                    .Where(f => File.GetLastWriteTime(f) < deadline).ToList().ForEach((logFile) =>
                    {
                        File.Delete(logFile);
                    });
            }
            catch
            {
            }
        }
    }
}
