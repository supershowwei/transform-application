namespace $safeprojectname$
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.OperatingPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MessageGridView = new System.Windows.Forms.DataGridView();
            this.HeartbeatTimer = new System.Windows.Forms.Timer(this.components);
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.JobPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OnceJobCheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatJobCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoScrollCheckBox = new System.Windows.Forms.CheckBox();
            this.ErrorGridView = new System.Windows.Forms.DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ErrorTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorMessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.OperatingPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).BeginInit();
            this.OptionPanel.SuspendLayout();
            this.JobPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Clock);
            this.TopPanel.Controls.Add(this.OperatingPanel);
            this.TopPanel.Controls.Add(this.LogoPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(624, 72);
            this.TopPanel.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.White;
            this.Clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clock.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clock.Location = new System.Drawing.Point(75, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(387, 72);
            this.Clock.TabIndex = 2;
            this.Clock.Text = "2012-12-31 00:00:00";
            this.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperatingPanel
            // 
            this.OperatingPanel.Controls.Add(this.ExitButton);
            this.OperatingPanel.Controls.Add(this.StopButton);
            this.OperatingPanel.Controls.Add(this.StartButton);
            this.OperatingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OperatingPanel.Location = new System.Drawing.Point(462, 0);
            this.OperatingPanel.Name = "OperatingPanel";
            this.OperatingPanel.Size = new System.Drawing.Size(162, 72);
            this.OperatingPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.Location = new System.Drawing.Point(84, 39);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "離　開";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StopButton.Location = new System.Drawing.Point(84, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 30);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "停　止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 66);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "開　始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LogoPanel.Size = new System.Drawing.Size(75, 72);
            this.LogoPanel.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(5, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 62);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // MessageGridView
            // 
            this.MessageGridView.AllowUserToAddRows = false;
            this.MessageGridView.AllowUserToDeleteRows = false;
            this.MessageGridView.AllowUserToResizeRows = false;
            this.MessageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.StatusColumn,
            this.MessageColumn});
            this.MessageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageGridView.Location = new System.Drawing.Point(0, 316);
            this.MessageGridView.Name = "MessageGridView";
            this.MessageGridView.ReadOnly = true;
            this.MessageGridView.RowHeadersVisible = false;
            this.MessageGridView.RowTemplate.Height = 24;
            this.MessageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MessageGridView.Size = new System.Drawing.Size(624, 286);
            this.MessageGridView.TabIndex = 3;
            this.MessageGridView.Tag = "";
            this.MessageGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.MessageGridView_RowsAdded);
            // 
            // HeartbeatTimer
            // 
            this.HeartbeatTimer.Enabled = true;
            this.HeartbeatTimer.Interval = 900;
            this.HeartbeatTimer.Tick += new System.EventHandler(this.HeartbeatTimer_Tick);
            // 
            // OptionPanel
            // 
            this.OptionPanel.Controls.Add(this.JobPanel);
            this.OptionPanel.Controls.Add(this.AutoScrollCheckBox);
            this.OptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionPanel.Location = new System.Drawing.Point(0, 72);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(624, 94);
            this.OptionPanel.TabIndex = 1;
            // 
            // JobPanel
            // 
            this.JobPanel.BackColor = System.Drawing.Color.White;
            this.JobPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JobPanel.Controls.Add(this.OnceJobCheckBox);
            this.JobPanel.Controls.Add(this.RepeatJobCheckBox);
            this.JobPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.JobPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JobPanel.Location = new System.Drawing.Point(0, 0);
            this.JobPanel.Name = "JobPanel";
            this.JobPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.JobPanel.Size = new System.Drawing.Size(624, 64);
            this.JobPanel.TabIndex = 0;
            // 
            // OnceJobCheckBox
            // 
            this.OnceJobCheckBox.AutoSize = true;
            this.OnceJobCheckBox.Location = new System.Drawing.Point(9, 3);
            this.OnceJobCheckBox.Name = "OnceJobCheckBox";
            this.OnceJobCheckBox.Size = new System.Drawing.Size(108, 24);
            this.OnceJobCheckBox.TabIndex = 0;
            this.OnceJobCheckBox.Text = "一次性工作";
            this.OnceJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // RepeatJobCheckBox
            // 
            this.RepeatJobCheckBox.AutoSize = true;
            this.RepeatJobCheckBox.Location = new System.Drawing.Point(123, 3);
            this.RepeatJobCheckBox.Name = "RepeatJobCheckBox";
            this.RepeatJobCheckBox.Size = new System.Drawing.Size(108, 24);
            this.RepeatJobCheckBox.TabIndex = 1;
            this.RepeatJobCheckBox.Text = "循環性工作";
            this.RepeatJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoScrollCheckBox
            // 
            this.AutoScrollCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoScrollCheckBox.AutoSize = true;
            this.AutoScrollCheckBox.Checked = true;
            this.AutoScrollCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrollCheckBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AutoScrollCheckBox.Location = new System.Drawing.Point(5, 70);
            this.AutoScrollCheckBox.Name = "AutoScrollCheckBox";
            this.AutoScrollCheckBox.Size = new System.Drawing.Size(118, 21);
            this.AutoScrollCheckBox.TabIndex = 1;
            this.AutoScrollCheckBox.Text = "自動捲動訊息列";
            this.AutoScrollCheckBox.UseVisualStyleBackColor = true;
            // 
            // ErrorGridView
            // 
            this.ErrorGridView.AllowUserToAddRows = false;
            this.ErrorGridView.AllowUserToDeleteRows = false;
            this.ErrorGridView.AllowUserToResizeRows = false;
            this.ErrorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HandleColumn,
            this.ErrorTimeColumn,
            this.ErrorMessageColumn});
            this.ErrorGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorGridView.Location = new System.Drawing.Point(0, 166);
            this.ErrorGridView.Name = "ErrorGridView";
            this.ErrorGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            this.ErrorGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ErrorGridView.RowTemplate.Height = 24;
            this.ErrorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorGridView.Size = new System.Drawing.Size(624, 150);
            this.ErrorGridView.TabIndex = 2;
            this.ErrorGridView.Tag = "";
            this.ErrorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ErrorGridView_CellContentClick);
            // 
            // TimeColumn
            // 
            this.TimeColumn.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "HH:mm:ss MM-dd-yyyy";
            this.TimeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.TimeColumn.Frozen = true;
            this.TimeColumn.HeaderText = "時間";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatusColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatusColumn.HeaderText = "狀態";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatusColumn.Width = 60;
            // 
            // MessageColumn
            // 
            this.MessageColumn.DataPropertyName = "Message";
            this.MessageColumn.HeaderText = "訊息";
            this.MessageColumn.Name = "MessageColumn";
            this.MessageColumn.ReadOnly = true;
            this.MessageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MessageColumn.Width = 500;
            // 
            // HandleColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandleColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.HandleColumn.Frozen = true;
            this.HandleColumn.HeaderText = "";
            this.HandleColumn.MinimumWidth = 40;
            this.HandleColumn.Name = "HandleColumn";
            this.HandleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HandleColumn.Text = "刪除";
            this.HandleColumn.UseColumnTextForButtonValue = true;
            this.HandleColumn.Width = 40;
            // 
            // ErrorTimeColumn
            // 
            this.ErrorTimeColumn.DataPropertyName = "Time";
            dataGridViewCellStyle4.Format = "HH:mm:ss MM-dd-yyyy";
            this.ErrorTimeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ErrorTimeColumn.Frozen = true;
            this.ErrorTimeColumn.HeaderText = "時間";
            this.ErrorTimeColumn.Name = "ErrorTimeColumn";
            this.ErrorTimeColumn.ReadOnly = true;
            this.ErrorTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ErrorMessageColumn
            // 
            this.ErrorMessageColumn.DataPropertyName = "Message";
            this.ErrorMessageColumn.HeaderText = "訊息";
            this.ErrorMessageColumn.Name = "ErrorMessageColumn";
            this.ErrorMessageColumn.ReadOnly = true;
            this.ErrorMessageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ErrorMessageColumn.Width = 550;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.MessageGridView);
            this.Controls.Add(this.ErrorGridView);
            this.Controls.Add(this.OptionPanel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 510);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.OperatingPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).EndInit();
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
            this.JobPanel.ResumeLayout(false);
            this.JobPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Panel OperatingPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataGridView MessageGridView;
        private System.Windows.Forms.Timer HeartbeatTimer;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.CheckBox AutoScrollCheckBox;
        private System.Windows.Forms.DataGridView ErrorGridView;
        private System.Windows.Forms.FlowLayoutPanel JobPanel;
        private System.Windows.Forms.CheckBox OnceJobCheckBox;
        private System.Windows.Forms.CheckBox RepeatJobCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HandleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessageColumn;
    }
}