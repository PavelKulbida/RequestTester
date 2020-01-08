namespace UI
{
    partial class RequestTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestTester));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.logPanel = new System.Windows.Forms.Panel();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.lbLogPath = new System.Windows.Forms.Label();
            this.sqlTesterControl = new UI.SqlTesterControl();
            this.httpTestControl = new UI.HttpTestControl();
            this.sqlTOweb = new UI.SqlToWeb();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sqlTesterControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.httpTestControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WEB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sqlTOweb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(729, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL -> WEB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbNotes);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(729, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Notepad";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            this.tbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotes.Location = new System.Drawing.Point(0, 0);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotes.Size = new System.Drawing.Size(729, 493);
            this.tbNotes.TabIndex = 0;
            this.tbNotes.Text = resources.GetString("tbNotes.Text");
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.tbLogPath);
            this.logPanel.Controls.Add(this.lbLogPath);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPanel.Location = new System.Drawing.Point(0, 519);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(737, 30);
            this.logPanel.TabIndex = 1;
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(65, 6);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(557, 20);
            this.tbLogPath.TabIndex = 1;
            this.tbLogPath.TextChanged += new System.EventHandler(this.tbLogPath_TextChanged);
            // 
            // lbLogPath
            // 
            this.lbLogPath.AutoSize = true;
            this.lbLogPath.Location = new System.Drawing.Point(9, 9);
            this.lbLogPath.Name = "lbLogPath";
            this.lbLogPath.Size = new System.Drawing.Size(50, 13);
            this.lbLogPath.TabIndex = 0;
            this.lbLogPath.Text = "LogPath:";
            // 
            // sqlTesterControl
            // 
            this.sqlTesterControl.ConnStr = "Data Source=localhost;Initial Catalog=kladr;Integrated Security=SSPI;\r\n";
            this.sqlTesterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlTesterControl.Location = new System.Drawing.Point(3, 3);
            this.sqlTesterControl.Name = "sqlTesterControl";
            this.sqlTesterControl.RepCount = 1;
            this.sqlTesterControl.Size = new System.Drawing.Size(723, 487);
            this.sqlTesterControl.SQLRequest = "SELECT * FROM [XapIndex]";
            this.sqlTesterControl.TA = "30";
            this.sqlTesterControl.TabIndex = 0;
            // 
            // httpTestControl
            // 
            this.httpTestControl.ContentType = "application/x-www-form-urlencoded";
            this.httpTestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpTestControl.EncoderName = "utf-8";
            this.httpTestControl.Location = new System.Drawing.Point(3, 3);
            this.httpTestControl.Method = "POST";
            this.httpTestControl.Name = "httpTestControl";
            this.httpTestControl.PostBody = "";
            this.httpTestControl.RepCount = 1;
            this.httpTestControl.Size = new System.Drawing.Size(723, 487);
            this.httpTestControl.TA = "30000";
            this.httpTestControl.TabIndex = 0;
            this.httpTestControl.Url = "http://localhost:9000/XapianServer/Service/Ready";
            // 
            // sqlTOweb
            // 
            this.sqlTOweb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlTOweb.Location = new System.Drawing.Point(0, 0);
            this.sqlTOweb.LogCount = 1;
            this.sqlTOweb.Name = "sqlTOweb";
            this.sqlTOweb.RqPattern = "{\r\n\"TypeMessage\":{\"Object\":\"RealtyObject\",\"Operation\":\"S\"},\r\n\"ActionData\":\"<<<SQL" +
    ":0>>>\"\r\n}";
            this.sqlTOweb.Size = new System.Drawing.Size(729, 493);
            this.sqlTOweb.TabIndex = 0;
            // 
            // RequestTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logPanel);
            this.Name = "RequestTester";
            this.Size = new System.Drawing.Size(737, 549);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UI.SqlTesterControl sqlTesterControl;
        private System.Windows.Forms.TabPage tabPage2;
        private UI.HttpTestControl httpTestControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbNotes;
        private UI.SqlToWeb sqlTOweb;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Label lbLogPath;
    }
}
