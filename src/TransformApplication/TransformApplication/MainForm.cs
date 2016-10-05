using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Core;
using Newtonsoft.Json;
using TransformApplication.Jobs;
using TransformApplication.Utilities;
using TransformApplication.ViewModels;

namespace TransformApplication
{
    public partial class MainForm : Form
    {
        private const string ApplicationName = "轉換程式";

        private static readonly Color[] Colors =
            {
                Color.FromArgb(255, 255, 255),  // 白
                Color.FromArgb(255, 0, 255),    // 桃紅
                Color.FromArgb(255, 128, 0),    // 橙
                Color.FromArgb(0, 255, 0),      // 綠
                Color.FromArgb(0, 255, 128),    // 淺綠
                Color.FromArgb(0, 0, 255),      // 藍
                Color.FromArgb(0, 128, 255),    // 淺藍
                Color.FromArgb(0, 128, 128),    // 藍綠
                Color.FromArgb(64, 0, 128),     // 紫
                Color.FromArgb(128, 128, 192)   // 淺紫
            };

        private static readonly ILog Log = LogManager.GetLogger(typeof(MainForm));
        private Task waitJobStopped;
        private bool isAutoStart;

        public MainForm(string[] args)
        {
            // 初始化元件
            InitializeComponent();

            // Assign ShowLogHandler
            ((ShowLogAppender)log4net.LogManager.GetRepository().GetAppenders().Where(a => a.Name == "ShowLogAppender").First()).ShowLogHandler = this.ShowWorkingMessage;

            // 是否自動執行
            if (args != null && args.Length > 0)
            {
                switch (args[0].ToUpper())
                {
                    case "/A":
                        this.isAutoStart = true;
                        break;
                    default:
                        this.isAutoStart = false;
                        break;
                }
            }

            // 視窗標題
            this.Text = string.Format("{0} v{1}", ApplicationName, Application.ProductVersion);

            // 時間 bar 初始化
            Clock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Clock.BackColor = Colors[new Random(Guid.NewGuid().GetHashCode()).Next(Colors.Length)];

            // 訊息視窗不自動產生欄位
            this.MessageGridView.AutoGenerateColumns = false;
            this.ErrorGridView.AutoGenerateColumns = false;

            // ToDo: Injet Jobs
            this.OnceJobCheckBox.Tag = new OnceJob(this.ExitApplication);
            this.RepeatJobCheckBox.Tag = new RepeatJob();
        }

        private enum ThenExecute
        {
            Stop,
            Exit
        }

        private List<Job> Jobs
        {
            get
            {
                return
                    JobPanel.Controls.Cast<Control>()
                        .Where(c => c.GetType() == typeof(CheckBox) && ((CheckBox)c).Checked)
                        .Select(c => (Job)c.Tag).ToList();
            }
        }

        private WindowAppearance WindowAppearance
        {
            get
            {
                return
                    new WindowAppearance()
                    {
                        X = this.Location.Y < -this.Height ? 0 : this.Location.X,
                        Y = this.Location.Y < -this.Height ? 0 : this.Location.Y,
                        Width = this.Width,
                        Height = this.Height
                    };
            }

            set
            {
                if (value == null)
                {
                    value =
                        new WindowAppearance()
                        {
                            X = 0,
                            Y = 0,
                            Width = 0,
                            Height = 0
                        };
                }

                this.Location = new Point(value.Y < -value.Height ? 0 : value.X, value.Y < -value.Height ? 0 : value.Y);
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }

        private DataGridViewAppearance MessageAppearance
        {
            get
            {
                return
                    new DataGridViewAppearance()
                    {
                        MaxRows = 1000,
                        ColumnAppearances = MessageGridView.Columns.Cast<DataGridViewColumn>().Select(c => new DataGridColumnAppearance(c.Name, c.Width)).ToList()
                    };
            }

            set
            {
                if (value == null)
                {
                    value =
                        new DataGridViewAppearance()
                        {
                            MaxRows = 1000,
                            ColumnAppearances =
                                new List<DataGridColumnAppearance>()
                                {
                                    new DataGridColumnAppearance("TimeColumn", 100),
                                    new DataGridColumnAppearance("StatusColumn", 60),
                                    new DataGridColumnAppearance("MessageColumn", 500)
                                }
                        };
                }

                value.ColumnAppearances.ForEach((c) =>
                {
                    MessageGridView.Columns[c.Name].Width = c.Width;
                });
            }
        }

        private DataGridViewAppearance ErrorAppearance
        {
            get
            {
                return
                    new DataGridViewAppearance()
                    {
                        MaxRows = 500,
                        ColumnAppearances = ErrorGridView.Columns.Cast<DataGridViewColumn>().Select(c => new DataGridColumnAppearance(c.Name, c.Width)).ToList()
                    };
            }

            set
            {
                if (value == null)
                {
                    value =
                        new DataGridViewAppearance()
                        {
                            MaxRows = 1000,
                            ColumnAppearances =
                                new List<DataGridColumnAppearance>()
                                {
                                    new DataGridColumnAppearance("HandleColumn", 25),
                                    new DataGridColumnAppearance("ErrorTimeColumn", 100),
                                    new DataGridColumnAppearance("ErrorMessageColumn", 550)
                                }
                        };
                }

                value.ColumnAppearances.ForEach((c) =>
                {
                    ErrorGridView.Columns[c.Name].Width = c.Width;
                });
            }
        }

        #region 訊息處理

        // 顯示訊息在訊息清單上
        private void ShowWorkingMessage(Level logLevel, string logMessage)
        {
            this.InvokeIfNecessary(() =>
            {
                this.MessageGridView.Rows.Add(DateTime.Now, logLevel.DisplayName, logMessage);

                if (this.AutoScrollCheckBox.Checked)
                {
                    // 若 MaxRows 設定大於 0，則從第1筆訊息逐筆刪除超過設定的最大訊息列數。
                    while (this.MessageGridView.Rows.Count > this.MessageAppearance.MaxRows)
                    {
                        this.MessageGridView.Rows.RemoveAt(0);
                    }

                    // 移至最後1筆記錄
                    this.MessageGridView.FirstDisplayedScrollingRowIndex = this.MessageGridView.Rows.Count - 1;
                }

                if (logLevel == Level.Error)
                {
                    this.ErrorGridView.Rows.Add(null, DateTime.Now, logMessage);
                }
            });
        }

        #endregion

        #region 工作狀態處理

        private void StartJob()
        {
            Properties.Settings.Default.LastJobsChecked = string.Join(",", this.Jobs.Select(j => j.GetType().Name));
            Properties.Settings.Default.Save();

            this.SwitchStartingState();

            // 作業開始
            this.Jobs.ForEach((job) =>
            {
                job.Start();
            });

            Log.Info("作業開始");
        }

        private void StopJob()
        {
            this.Jobs.ForEach((job) =>
            {
                if (job.IsExecuting)
                {
                    job.Stop();
                }
            });
        }

        private void JobStopping(ThenExecute thenExecute)
        {
            if (this.waitJobStopped == null || this.waitJobStopped.Status != TaskStatus.Running)
            {
                this.waitJobStopped = new Task(() =>
                {
                    while (Jobs.Any((job) => job.IsExecuting))
                    {
                        Thread.Sleep(1000);
                    }
                });

                this.waitJobStopped.ContinueWith((wAitjobStopped) =>
                {
                    this.InvokeIfNecessary(() =>
                    {
                        switch (thenExecute)
                        {
                            case ThenExecute.Stop:
                                {
                                    Log.Info("作業停止");
                                    this.SwitchStoppedState();
                                }

                                break;
                            case ThenExecute.Exit:
                                {
                                    Application.Exit();
                                }

                                break;
                        }
                    });
                });

                this.waitJobStopped.Start();
            }
        }

        private void ExitApplication()
        {
            this.InvokeIfNecessary(() =>
            {
                Log.Info("工作執行完畢");
                MessageBox.Show("工作執行完畢，即將關閉視窗！", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            });
        }

        #endregion

        #region 按鈕狀態處理

        private void SwitchStartingState()
        {
            JobPanel.Enabled = false;
            StartButton.Enabled = false;
            StopButton.Enabled = true;
        }

        private void SwitchStoppedState()
        {
            JobPanel.Enabled = true;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }

        #endregion

        #region EventHandler

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 載入畫面設定
            this.WindowAppearance = WindowAppearance.Parse(Properties.Settings.Default.WindowAppearance);
            this.MessageAppearance = DataGridViewAppearance.Parse(Properties.Settings.Default.MessageAppearance);
            this.ErrorAppearance = DataGridViewAppearance.Parse(Properties.Settings.Default.ErrorAppearance);

            // 載入上次執行作業
            foreach (CheckBox checkBox in JobPanel.Controls.Cast<Control>().Where(c => c.GetType() == typeof(CheckBox)))
            {
                if (Properties.Settings.Default.LastJobsChecked.Split(',').Contains(checkBox.Tag.GetType().Name))
                {
                    ((CheckBox)checkBox).Checked = true;
                }
            }

            // 註冊畫面變動相關事件
            this.LocationChanged += this.MainForm_LocationChanged;
            this.Resize += this.MainForm_Resize;
            this.MessageGridView.ColumnWidthChanged += this.MessageGridView_ColumnWidthChanged;
            this.ErrorGridView.ColumnWidthChanged += this.ErrorGridView_ColumnWidthChanged;

            // 一次性工作：能下參數自動執行，執行完畢跳出視窗提醒工作執行完成。
            if (this.isAutoStart)
            {
                this.SwitchStartingState();

                // 作業開始
                this.Jobs.ForEach((job) =>
                {
                    job.Start();
                });
            }
        }

        // 開始
        private void StartButton_Click(object sender, EventArgs e)
        {
            Log.Info("使用者點擊開始");

            if (this.Jobs.Count > 0)
            {
                this.StartJob();
            }
            else
            {
                MessageBox.Show("請至少選擇一個作業！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 停止
        private void StopButton_Click(object sender, EventArgs e)
        {
            Log.Info("使用者點擊停止");

            this.StopJob();

            if (this.Jobs.All((job) => !job.IsExecuting))
            {
                Log.Info("作業停止");
                this.SwitchStoppedState();
            }
            else
            {
                this.JobStopping(ThenExecute.Stop);

                MessageBox.Show("部分作業尚未結束，待結束後會立即停止作業 !!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 離開
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Log.Info("使用者點擊離開");

            this.StopJob();

            if (this.Jobs.Count == 0 || this.Jobs.All((job) => !job.IsExecuting))
            {
                Application.Exit();
            }
            else
            {
                this.JobStopping(ThenExecute.Exit);

                MessageBox.Show("部分作業尚未結束，待結束後會立即關閉程式 !!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 程式心跳
        private void HeartbeatTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Millisecond < 100)
            {
                return;
            }

            Clock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Clock.BackColor = Colors[(new Random(Guid.NewGuid().GetHashCode())).Next(Colors.Length)];

            Application.DoEvents();

            // 寫 MonitorFile (1次/1分鐘)，且「開始」按鈕為不可按的狀態才寫。
            if (DateTime.Now.Second == 0 && StartButton.Enabled == false)
            {
                Heartbeat.Beat();
            }

            // 每天 00:00:00 刪除一個月前的記錄檔
            if (DateTime.Now.ToString("HHmmss") == "000000")
            {
                Task.Run(() => { Optimizer.OptimizeEnvironment(); });
            }
        }

        // 儲存工作訊息欄寬
        private void MessageGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Properties.Settings.Default.MessageAppearance = JsonConvert.SerializeObject(this.MessageAppearance);
            Properties.Settings.Default.Save();
        }

        // 儲存錯誤訊息欄寬
        private void ErrorGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Properties.Settings.Default.ErrorAppearance = JsonConvert.SerializeObject(this.ErrorAppearance);
            Properties.Settings.Default.Save();
        }

        // 訊息狀態決定訊息列顯示的顏色
        private void MessageGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            switch ((string)((DataGridView)sender).Rows[e.RowIndex].Cells["StatusColumn"].Value)
            {
                case "WARN":
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    break;
                case "ERROR":
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    break;
            }
        }

        // 使用者點擊處理錯誤訊息的 CheckBox
        private void ErrorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 若點擊 CheckBox，則才處理後續工作。
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("確定問題已處理完成？", "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Log.Info("使用者處理了錯誤訊息：" + this.ErrorGridView.Rows[e.RowIndex].Cells["ErrorMessageColumn"].Value);

                    this.ErrorGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // 儲存視窗位置
        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowAppearance = JsonConvert.SerializeObject(this.WindowAppearance);
            Properties.Settings.Default.Save();
        }

        // 儲存視窗大小
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowAppearance = JsonConvert.SerializeObject(this.WindowAppearance);
            Properties.Settings.Default.Save();
        }

        // 程式即將關閉
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ErrorGridView.Rows.Count > 0 && MessageBox.Show("程式執行過程中有錯誤發生，確定要關閉程式？", "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;

                this.InvokeIfNecessary(() =>
                {
                    SwitchStoppedState();
                });
            }
        }

        #endregion
    }
}
