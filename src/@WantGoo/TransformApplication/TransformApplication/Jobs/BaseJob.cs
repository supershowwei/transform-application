using System;
using System.Threading;
using System.Threading.Tasks;

namespace TransformApplication.Jobs
{
    internal abstract class BaseJob
    {
        protected string name;
        private DateTime? now;

        protected BaseJob(string name)
        {
            this.name = name;
        }

        public Task Task { get; private set; }

        protected DateTime Today
        {
            get
            {
                return this.now ?? DateTime.Now.Date;
            }
        }

        protected DateTime Yesterday
        {
            get
            {
                return this.now ?? DateTime.Now.AddDays(-1).Date;
            }
        }

        public void Run(Action jobCompleted = null, CancellationTokenSource cancellationTokenSource = null)
        {
            this.Task = Task.Run(() => { this.Do(cancellationTokenSource); });

            this.Task.ContinueWith(
                task =>
                    {
                        if (jobCompleted != null) jobCompleted();
                    },
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        public void SetCustomDate(DateTime? date)
        {
            this.now = date;
        }

        protected abstract void Do(CancellationTokenSource cancellationTokenSource);

        protected DateTime BeforeToday(double value)
        {
            return this.now ?? DateTime.Now.AddDays(-value).Date;
        }
    }
}