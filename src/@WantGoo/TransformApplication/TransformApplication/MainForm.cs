using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Core;
using TransformApplication.Jobs;

namespace TransformApplication
{
    public partial class MainForm : Form
    {
        private static readonly int MaxRowsCount = 5000;
        private static readonly string Title = "資料爬蟲";
        private readonly bool isCommandMode;

        private readonly SafeQueue<Tuple<DateTime, Level, string>> logQueue =
            new SafeQueue<Tuple<DateTime, Level, string>>();

        private CancellationTokenSource cancellationTokenSource;

        private Task logsDequeuingTask;

        public MainForm(string[] args)
        {
            this.InitializeComponent();

            this.Text = Title;

            LogManager.GetRepository()
                .GetAppenders()
                .OfType<ForegroundPropagationAppender>()
                .ToList()
                .ForEach(appender => { appender.Propagation = this.PropagateLog; });

            this.logQueue.Enqueued += this.LogEnqueued;

            this.CreateJobs();

            // 判斷指令模式
            this.isCommandMode = (args != null) && (args.Length > 0)
                                 && args.All(x => this.JobPanel.Controls.OfType<CheckBox>().Any(c => c.Text.Equals(x)));

            if (this.isCommandMode)
            {
                foreach (var checkBox in this.JobPanel.Controls.OfType<CheckBox>().Where(c => args.Contains(c.Text)))
                {
                    checkBox.Checked = true;
                }
            }
        }

        private List<IJob> Jobs
        {
            get
            {
                return
                    this.JobPanel.Controls.OfType<CheckBox>().Where(b => b.Checked).Select(b => b.Tag as IJob).ToList();
            }
        }

        private void AppendErrorMessage(DateTime timeStamp, string message)
        {
            this.ErrorMessageGridView.InvokeIfNecessary(
                () =>
                    {
                        this.ErrorMessageGridView.Rows.Add(timeStamp, message);

                        this.KeepMaxRowsCount(this.ErrorMessageGridView, MaxRowsCount);

                        this.ScrollToEnd(this.ErrorMessageGridView);
                    });
        }

        private void AppendMessage(DateTime timeStamp, Level level, string message)
        {
            this.MessageGridView.InvokeIfNecessary(
                () =>
                    {
                        this.MessageGridView.Rows.Add(timeStamp, level.DisplayName, message);

                        this.KeepMaxRowsCount(this.MessageGridView, MaxRowsCount);

                        this.ScrollToEnd(this.MessageGridView);
                    });
        }

        private void CreateJobs()
        {
            foreach (var checkBox in this.JobPanel.Controls.OfType<CheckBox>())
            {
                checkBox.Tag = JobFactory.GenerateJob(checkBox.Text);
            }
        }

        private void CustomDateChanged(object sender, EventArgs e)
        {
            var datePicker = (DateTimePicker)sender;
            var isCustomDateUsed = datePicker.Checked;

            foreach (var checkBox in this.JobPanel.Controls.OfType<CheckBox>())
            {
                ((IJob)checkBox.Tag).SetCustomDate(isCustomDateUsed ? datePicker.Value.Date : default(DateTime?));
            }
        }

        private void Debug(object sender, EventArgs e)
        {
        }

        private void DequeueLogs()
        {
            while (!this.logQueue.IsEmpty)
            {
                Tuple<DateTime, Level, string> logMessage;
                if (this.logQueue.TryDequeue(out logMessage))
                {
                    this.AppendMessage(logMessage.Item1, logMessage.Item2, logMessage.Item3);

                    if (logMessage.Item2 == Level.Error)
                    {
                        this.AppendErrorMessage(logMessage.Item1, logMessage.Item3);
                    }
                }
            }
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        private void JobCompleted()
        {
            if (this.Jobs.All(j => j.Task.IsCompleted))
            {
                // 所有工作已經停止或完成
                if (this.isCommandMode)
                {
                    this.ExitApplication();
                }
                else
                {
                    this.SwitchToIdle();
                }
            }
        }

        private void KeepMaxRowsCount(DataGridView gridView, int maxRowsCount)
        {
            while (gridView.Rows.Count > maxRowsCount)
            {
                gridView.Rows.RemoveAt(0);
            }
        }

        private void LogEnqueued(object sender, EventArgs e)
        {
            if ((this.logsDequeuingTask == null) || this.logsDequeuingTask.IsCompleted)
            {
                this.logsDequeuingTask = Task.Run(() => this.DequeueLogs());
            }
        }

        private void MainFormShown(object sender, EventArgs e)
        {
            if (this.isCommandMode)
            {
                this.StartJobs(this.StartButton, null);
            }
        }

        private void MessageGridViewRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var gridView = sender as DataGridView;

            switch ((string)gridView.Rows[e.RowIndex].Cells["MessageLevel"].Value)
            {
                case "DEBUG":
                    gridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                    break;
                case "WARN":
                    gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    break;
                case "ERROR":
                    gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                    break;
            }
        }

        // 提供給 ForegroundPropagationAppender 用的 method
        private void PropagateLog(DateTime timeStamp, Level level, string message)
        {
            this.logQueue.Enqueue(Tuple.Create(timeStamp, level, message));
        }

        private void ScrollToEnd(DataGridView gridView)
        {
            gridView.FirstDisplayedScrollingRowIndex = gridView.Rows.Count - 1;
        }

        // 開始工作
        private void StartJobs(object sender, EventArgs e)
        {
            if (this.Jobs.Count.Equals(0))
            {
                MessageBox.Show("請至少選擇一個工作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.StartButton.Enabled = false;

                this.cancellationTokenSource = new CancellationTokenSource();
                this.Jobs.ForEach(job => job.Run(this.JobCompleted, this.cancellationTokenSource));

                this.SwitchToRunning();
            }
        }

        // 停止工作
        private void StopJobs(object sender, EventArgs e)
        {
            this.StopButton.Enabled = false;

            this.cancellationTokenSource.Cancel();
        }

        private void SwitchToIdle()
        {
            this.InvokeIfNecessary(
                () =>
                    {
                        this.StartButton.Enabled = true;
                        this.StopButton.Enabled = false;
                        this.JobPanel.Enabled = true;
                        this.CustomDatePicker.Enabled = true;
                    });
        }

        private void SwitchToRunning()
        {
            this.InvokeIfNecessary(
                () =>
                    {
                        this.StartButton.Enabled = false;
                        this.StopButton.Enabled = true;
                        this.JobPanel.Enabled = false;
                        this.CustomDatePicker.Enabled = false;
                    });
        }
    }
}