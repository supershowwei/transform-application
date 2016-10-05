using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransformApplication.Jobs
{
    class RepeatJob : Job
    {
        private DateTime latestExecutionTime;
        private bool isWorking;
        private bool stopWorking;

        public RepeatJob()
        {
        }

        public override bool IsExecuting
        {
            get { return this.isWorking; }
        }

        public override void Start()
        {
            this.isWorking = true;
            this.stopWorking = false;
            this.latestExecutionTime = DateTime.Now;

            Task.Run(() => this.Polling());
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
        }

        private void Polling()
        {
            while (!this.stopWorking)
            {
                // 超過預定的執行區間才執行工作
                if (DateTime.Now.Subtract(this.latestExecutionTime).TotalSeconds >= 1)
                {
                    this.latestExecutionTime = DateTime.Now;

                    this.Work();
                }

                Thread.Sleep(1000);
            }

            this.isWorking = false;
        }
    }
}
