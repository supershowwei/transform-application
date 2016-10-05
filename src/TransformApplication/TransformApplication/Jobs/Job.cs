using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace TransformApplication.Jobs
{
    delegate void ExitHandler();

    abstract class Job
    {
        protected ILog Log { get; private set; }

        public Job()
        {
            Log = LogManager.GetLogger(this.GetType());
        }

        public abstract bool IsExecuting { get; }

        public abstract void Start();

        public abstract void Stop();

        protected abstract void Work(params object[] args);
    }
}
