namespace UI
{
    partial class SqlTesterControl
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
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbMaxRezShow = new System.Windows.Forms.Label();
            this.tbMazRezShow = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbConnection = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.tbRezCount = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbTA = new System.Windows.Forms.TextBox();
            this.lbTA = new System.Windows.Forms.Label();
            this.panelParam.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.tbTA);
            this.panelParam.Controls.Add(this.lbTA);
            this.panelParam.Controls.Add(this.lblConnect);
            this.panelParam.Controls.Add(this.lbCount);
            this.panelParam.Controls.Add(this.lblTime);
            this.panelParam.Controls.Add(this.btnConnect);
            this.panelParam.Controls.Add(this.lbMaxRezShow);
            this.panelParam.Controls.Add(this.tbMazRezShow);
            this.panelParam.Controls.Add(this.lblCount);
            this.panelParam.Controls.Add(this.tbConnection);
            this.panelParam.Controls.Add(this.lblRequest);
            this.panelParam.Controls.Add(this.tbRequest);
            this.panelParam.Controls.Add(this.tbCount);
            this.panelParam.Controls.Add(this.btnStartTest);
            this.panelParam.Controls.Add(this.tbRezCount);
            this.panelParam.Controls.Add(this.tbTime);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParam.Location = new System.Drawing.Point(0, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(774, 274);
            this.panelParam.TabIndex = 0;
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(16, 14);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(89, 13);
            this.lblConnect.TabIndex = 0;
            this.lblConnect.Text = "Connection string";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(424, 212);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(463, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 27);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbMaxRezShow
            // 
            this.lbMaxRezShow.AutoSize = true;
            this.lbMaxRezShow.Location = new System.Drawing.Point(16, 243);
            this.lbMaxRezShow.Name = "lbMaxRezShow";
            this.lbMaxRezShow.Size = new System.Drawing.Size(93, 13);
            this.lbMaxRezShow.TabIndex = 9;
            this.lbMaxRezShow.Text = "Max Result Show:";
            // 
            // tbMazRezShow
            // 
            this.tbMazRezShow.Location = new System.Drawing.Point(111, 240);
            this.tbMazRezShow.Name = "tbMazRezShow";
            this.tbMazRezShow.ReadOnly = true;
            this.tbMazRezShow.Size = new System.Drawing.Size(85, 20);
            this.tbMazRezShow.TabIndex = 10;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(16, 212);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(75, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Repeat count:";
            // 
            // tbConnection
            // 
            this.tbConnection.Location = new System.Drawing.Point(14, 40);
            this.tbConnection.Multiline = true;
            this.tbConnection.Name = "tbConnection";
            this.tbConnection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConnection.Size = new System.Drawing.Size(592, 57);
            this.tbConnection.TabIndex = 1;
            this.tbConnection.Text = "Data Source=localhost;Initial Catalog=kladr;Integrated Security=SSPI;\r\n";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(16, 113);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(71, 13);
            this.lblRequest.TabIndex = 3;
            this.lblRequest.Text = "SQL Request";
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(14, 138);
            this.tbRequest.Multiline = true;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.ReadOnly = true;
            this.tbRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRequest.Size = new System.Drawing.Size(592, 57);
            this.tbRequest.TabIndex = 6;
            this.tbRequest.Text = "SELECT * FROM [XapIndex]";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(111, 209);
            this.tbCount.Name = "tbCount";
            this.tbCount.ReadOnly = true;
            this.tbCount.Size = new System.Drawing.Size(85, 20);
            this.tbCount.TabIndex = 8;
            this.tbCount.Text = "1";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Enabled = false;
            this.btnStartTest.Location = new System.Drawing.Point(224, 209);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(179, 51);
            this.btnStartTest.TabIndex = 11;
            this.btnStartTest.Text = "Execute";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(463, 209);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(143, 20);
            this.tbTime.TabIndex = 13;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(774, 354);
            this.tbLog.TabIndex = 0;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.tbLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(0, 274);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(774, 354);
            this.panelLog.TabIndex = 14;
            // 
            // tbRezCount
            // 
            this.tbRezCount.Location = new System.Drawing.Point(463, 235);
            this.tbRezCount.Name = "tbRezCount";
            this.tbRezCount.ReadOnly = true;
            this.tbRezCount.Size = new System.Drawing.Size(143, 20);
            this.tbRezCount.TabIndex = 15;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(424, 238);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(38, 13);
            this.lbCount.TabIndex = 14;
            this.lbCount.Text = "Count:";
            // 
            // tbTA
            // 
            this.tbTA.Location = new System.Drawing.Point(488, 110);
            this.tbTA.Name = "tbTA";
            this.tbTA.Size = new System.Drawing.Size(118, 20);
            this.tbTA.TabIndex = 5;
            this.tbTA.Text = "30";
            // 
            // lbTA
            // 
            this.lbTA.AutoSize = true;
            this.lbTA.Location = new System.Drawing.Point(355, 113);
            this.lbTA.Name = "lbTA";
            this.lbTA.Size = new System.Drawing.Size(121, 13);
            this.lbTA.TabIndex = 4;
            this.lbTA.Text = "Request TimeOut (Sec):";
            // 
            // SqlTesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelParam);
            this.Name = "SqlTesterControl";
            this.Size = new System.Drawing.Size(774, 628);
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox tbConnection;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label lbMaxRezShow;
        private System.Windows.Forms.TextBox tbMazRezShow;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbRezCount;
        private System.Windows.Forms.TextBox tbTA;
        private System.Windows.Forms.Label lbTA;
    }
}
