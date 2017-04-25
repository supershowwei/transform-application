using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace TransformApplication
{
    internal static class Program
    {
        /// <summary>
        ///     應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            GlobalContext.Properties["ApplicationName"] = Assembly.GetExecutingAssembly().GetName().Name;
            GlobalContext.Properties["CurrentDirectory"] =
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var configFile = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "log4net.config");

            XmlConfigurator.ConfigureAndWatch(new FileInfo(configFile));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }
    }
}