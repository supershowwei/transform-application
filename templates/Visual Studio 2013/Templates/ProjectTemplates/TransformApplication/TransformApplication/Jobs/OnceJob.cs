using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace $safeprojectname$.Jobs
{
    class OnceJob : Job
    {
        private bool stopWorking;
        private Task task;
        private ExitHandler exit;

        public OnceJob(ExitHandler exit)
        {
            this.stopWorking = false;
            this.exit = exit;
        }

        public override bool IsExecuting
        {
            get
            {
                return this.task != null && this.task.Status == TaskStatus.Running;
            }
        }

        public override void Start()
        {
            this.task = new Task(() =>
            {
                this.Work();
            });

            this.task.Start();
        }

        public override void Stop()
        {
            this.stopWorking = true;
        }

        protected override void Work(params object[] args)
        {
            try
            {
                // ToDo: Job

                // Test Debug
                Log.Debug("Debug");

                //  Test Log
                Log.Info("Info");

                //  Test Warning
                Log.Warn("Warning");

                //  Test Error
                Log.Error("Error");

                // ToDo: isCancel 等於 true 時，記得處理跳出迴圈。

                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                // ToDo: Writelog
            }

            this.exit();
        }
    }
}
