namespace TransformApplication
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DebugButton = new System.Windows.Forms.Button();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.RepresentativeImage = new System.Windows.Forms.PictureBox();
            this.ErrorMessagePanel = new System.Windows.Forms.Panel();
            this.ErrorMessageGridView = new System.Windows.Forms.DataGridView();
            this.JobPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MessageGridView = new System.Windows.Forms.DataGridView();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.ErrorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativeImage)).BeginInit();
            this.ErrorMessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageGridView)).BeginInit();
            this.JobPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).BeginInit();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.CustomDatePicker);
            this.TopPanel.Controls.Add(this.DebugButton);
            this.TopPanel.Controls.Add(this.DebugLabel);
            this.TopPanel.Controls.Add(this.StopButton);
            this.TopPanel.Controls.Add(this.StartButton);
            this.TopPanel.Controls.Add(this.RepresentativeImage);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(624, 58);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(249, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "手動日期：";
            // 
            // CustomDatePicker
            // 
            this.CustomDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomDatePicker.Checked = false;
            this.CustomDatePicker.CustomFormat = "yyyy / MM / dd";
            this.CustomDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomDatePicker.Location = new System.Drawing.Point(338, 27);
            this.CustomDatePicker.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CustomDatePicker.Name = "CustomDatePicker";
            this.CustomDatePicker.ShowCheckBox = true;
            this.CustomDatePicker.Size = new System.Drawing.Size(145, 25);
            this.CustomDatePicker.TabIndex = 0;
            this.CustomDatePicker.ValueChanged += new System.EventHandler(this.CustomDateChanged);
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(61, 5);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(64, 48);
            this.DebugButton.TabIndex = 3;
            this.DebugButton.Text = "Debug";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Visible = false;
            this.DebugButton.Click += new System.EventHandler(this.Debug);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(131, 9);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(78, 17);
            this.DebugLabel.TabIndex = 4;
            this.DebugLabel.Text = "debug label";
            this.DebugLabel.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StopButton.Location = new System.Drawing.Point(486, 5);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(64, 48);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "停止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopJobs);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.Location = new System.Drawing.Point(555, 5);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(64, 48);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartJobs);
            // 
            // RepresentativeImage
            // 
            this.RepresentativeImage.Image = ((System.Drawing.Image)(resources.GetObject("RepresentativeImage.Image")));
            this.RepresentativeImage.Location = new System.Drawing.Point(5, 5);
            this.RepresentativeImage.Margin = new System.Windows.Forms.Padding(5);
            this.RepresentativeImage.Name = "RepresentativeImage";
            this.RepresentativeImage.Size = new System.Drawing.Size(48, 48);
            this.RepresentativeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RepresentativeImage.TabIndex = 0;
            this.RepresentativeImage.TabStop = false;
            // 
            // ErrorMessagePanel
            // 
            this.ErrorMessagePanel.Controls.Add(this.ErrorMessageGridView);
            this.ErrorMessagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorMessagePanel.Location = new System.Drawing.Point(160, 58);
            this.ErrorMessagePanel.Name = "ErrorMessagePanel";
            this.ErrorMessagePanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ErrorMessagePanel.Size = new System.Drawing.Size(464, 153);
            this.ErrorMessagePanel.TabIndex = 2;
            // 
            // ErrorMessageGridView
            // 
            this.ErrorMessageGridView.AllowUserToAddRows = false;
            this.ErrorMessageGridView.AllowUserToDeleteRows = false;
            this.ErrorMessageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorMessageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorTime,
            this.ErrorMessage});
            this.ErrorMessageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorMessageGridView.Location = new System.Drawing.Point(3, 0);
            this.ErrorMessageGridView.Name = "ErrorMessageGridView";
            this.ErrorMessageGridView.ReadOnly = true;
            this.ErrorMessageGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            this.ErrorMessageGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ErrorMessageGridView.RowTemplate.Height = 24;
            this.ErrorMessageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorMessageGridView.Size = new System.Drawing.Size(458, 150);
            this.ErrorMessageGridView.TabIndex = 0;
            // 
            // JobPanel
            // 
            this.JobPanel.AutoScroll = true;
            this.JobPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JobPanel.Controls.Add(this.checkBox1);
            this.JobPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.JobPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.JobPanel.Location = new System.Drawing.Point(0, 58);
            this.JobPanel.Name = "JobPanel";
            this.JobPanel.Padding = new System.Windows.Forms.Padding(3);
            this.JobPanel.Size = new System.Drawing.Size(160, 383);
            this.JobPanel.TabIndex = 0;
            this.JobPanel.WrapContents = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "TestJob";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MessageGridView
            // 
            this.MessageGridView.AllowUserToAddRows = false;
            this.MessageGridView.AllowUserToDeleteRows = false;
            this.MessageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageTime,
            this.MessageLevel,
            this.Message});
            this.MessageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageGridView.Location = new System.Drawing.Point(3, 3);
            this.MessageGridView.Name = "MessageGridView";
            this.MessageGridView.ReadOnly = true;
            this.MessageGridView.RowHeadersVisible = false;
            this.MessageGridView.RowTemplate.Height = 24;
            this.MessageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MessageGridView.Size = new System.Drawing.Size(458, 224);
            this.MessageGridView.TabIndex = 3;
            this.MessageGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.MessageGridViewRowsAdded);
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.MessageGridView);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(160, 211);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Padding = new System.Windows.Forms.Padding(3);
            this.MessagePanel.Size = new System.Drawing.Size(464, 230);
            this.MessagePanel.TabIndex = 3;
            // 
            // ErrorTime
            // 
            dataGridViewCellStyle1.Format = "HH:mm:ss yyyy-MM-dd";
            dataGridViewCellStyle1.NullValue = null;
            this.ErrorTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ErrorTime.Frozen = true;
            this.ErrorTime.HeaderText = "時間";
            this.ErrorTime.MinimumWidth = 80;
            this.ErrorTime.Name = "ErrorTime";
            this.ErrorTime.ReadOnly = true;
            this.ErrorTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ErrorTime.Width = 80;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.HeaderText = "錯誤訊息";
            this.ErrorMessage.MinimumWidth = 358;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.ReadOnly = true;
            this.ErrorMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ErrorMessage.Width = 358;
            // 
            // MessageTime
            // 
            dataGridViewCellStyle3.Format = "HH:mm:ss yyyy-MM-dd";
            this.MessageTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.MessageTime.Frozen = true;
            this.MessageTime.HeaderText = "時間";
            this.MessageTime.MinimumWidth = 80;
            this.MessageTime.Name = "MessageTime";
            this.MessageTime.ReadOnly = true;
            this.MessageTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MessageTime.Width = 80;
            // 
            // MessageLevel
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MessageLevel.DefaultCellStyle = dataGridViewCellStyle4;
            this.MessageLevel.HeaderText = "等級";
            this.MessageLevel.MinimumWidth = 60;
            this.MessageLevel.Name = "MessageLevel";
            this.MessageLevel.ReadOnly = true;
            this.MessageLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MessageLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MessageLevel.Width = 60;
            // 
            // Message
            // 
            this.Message.HeaderText = "訊息";
            this.Message.MinimumWidth = 298;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Message.Width = 298;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.ErrorMessagePanel);
            this.Controls.Add(this.JobPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativeImage)).EndInit();
            this.ErrorMessagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageGridView)).EndInit();
            this.JobPanel.ResumeLayout(false);
            this.JobPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).EndInit();
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox RepresentativeImage;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel ErrorMessagePanel;
        private System.Windows.Forms.DataGridView ErrorMessageGridView;
        private System.Windows.Forms.FlowLayoutPanel JobPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView MessageGridView;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.DateTimePicker CustomDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;


    }
}

