using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TransformApplication.Utilities
{
    class Heartbeat
    {
        public static void Beat()
        {
            try
            {
                string filePath =
                    Path.Combine(
                        Properties.Settings.Default.MonitorFilePath,
                        Assembly.GetExecutingAssembly().GetName().Name + "-0-" + Environment.MachineName + ".mon");

                using (StreamWriter logWriter = new StreamWriter(filePath, false, Encoding.GetEncoding("Big5")))
                {
                    logWriter.Write(
                        Assembly.GetExecutingAssembly().GetName().Name + " " +
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                }
            }
            catch // 無論 Monitor File 有沒有寫成功，都不要影響程式執行。
            {
            }
        }
    }
}
