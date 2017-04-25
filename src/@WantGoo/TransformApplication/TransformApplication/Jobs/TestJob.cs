using System.Threading;
using log4net;
using log4net.Core;

namespace TransformApplication.Jobs
{
    internal class TestJob : Job, IJob
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TestJob));

        public TestJob(string name)
            : base(name)
        {
        }

        protected override void Do(CancellationTokenSource cancellationTokenSource)
        {
            Log.Logger.Log(null, Level.Notice, string.Format("{0} start !", this.name), null);

            while (true)
            {
                if (cancellationTokenSource.IsCancellationRequested)
                {
                    break;
                }

                Log.Debug("debug");
                Log.InfoFormat("info {0}", this.Today);
                Log.Logger.Log(null, Level.Notice, "notice", null);
                Log.Warn("warn");
                Log.Error("error");

                Thread.Sleep(1000);
            }
        }
    }
}