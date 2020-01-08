namespace UI
{
    public partial class SqlToWeb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelParam = new System.Windows.Forms.Panel();
            this.tbLogWriteCount = new System.Windows.Forms.TextBox();
            this.lbLogCount = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.lbEntity = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panelParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.tbLogWriteCount);
            this.panelParam.Controls.Add(this.lbLogCount);
            this.panelParam.Controls.Add(this.tbTime);
            this.panelParam.Controls.Add(this.lbTime);
            this.panelParam.Controls.Add(this.progressBar);
            this.panelParam.Controls.Add(this.btnStop);
            this.panelParam.Controls.Add(this.btnStart);
            this.panelParam.Controls.Add(this.tbPattern);
            this.panelParam.Controls.Add(this.lbEntity);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParam.Location = new System.Drawing.Point(0, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(547, 300);
            this.panelParam.TabIndex = 0;
            // 
            // tbLogWriteCount
            // 
            this.tbLogWriteCount.Location = new System.Drawing.Point(121, 189);
            this.tbLogWriteCount.Name = "tbLogWriteCount";
            this.tbLogWriteCount.Size = new System.Drawing.Size(100, 20);
            this.tbLogWriteCount.TabIndex = 3;
            this.tbLogWriteCount.Text = "1";
            // 
            // lbLogCount
            // 
            this.lbLogCount.AutoSize = true;
            this.lbLogCount.Location = new System.Drawing.Point(24, 192);
            this.lbLogCount.Name = "lbLogCount";
            this.lbLogCount.Size = new System.Drawing.Size(87, 13);
            this.lbLogCount.TabIndex = 2;
            this.lbLogCount.Text = "Log Write Count:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(358, 266);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(169, 20);
            this.tbTime.TabIndex = 8;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(262, 273);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 13);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "Time:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(265, 228);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(262, 32);
            this.progressBar.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(410, 189);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 33);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(265, 189);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(27, 25);
            this.tbPattern.Multiline = true;
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPattern.Size = new System.Drawing.Size(500, 158);
            this.tbPattern.TabIndex = 1;
            this.tbPattern.Text = "{\r\n\"TypeMessage\":{\"Object\":\"Address\",\"Operation\":\"C\"},\r\n\"ActionData\":\"<<<SQL:0>>>" +
    "\"\r\n}";
            this.tbPattern.WordWrap = false;
            // 
            // lbEntity
            // 
            this.lbEntity.AutoSize = true;
            this.lbEntity.Location = new System.Drawing.Point(24, 9);
            this.lbEntity.Name = "lbEntity";
            this.lbEntity.Size = new System.Drawing.Size(97, 13);
            this.lbEntity.TabIndex = 0;
            this.lbEntity.Text = "Request Template:";
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 300);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(547, 228);
            this.tbLog.TabIndex = 1;
            // 
            // SqlToWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.panelParam);
            this.Name = "SqlToWeb";
            this.Size = new System.Drawing.Size(547, 528);
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.Label lbEntity;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbLogWriteCount;
        private System.Windows.Forms.Label lbLogCount;

    }
}
