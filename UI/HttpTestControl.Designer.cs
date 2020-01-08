namespace UI
{
    partial class HttpTestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HttpTestControl));
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.tbPostBody = new System.Windows.Forms.TextBox();
            this.lbPostBody = new System.Windows.Forms.Label();
            this.tbContentType = new System.Windows.Forms.TextBox();
            this.tbTA = new System.Windows.Forms.TextBox();
            this.tbMethod = new System.Windows.Forms.TextBox();
            this.lbTA = new System.Windows.Forms.Label();
            this.lbContentType = new System.Windows.Forms.Label();
            this.lbMethod = new System.Windows.Forms.Label();
            this.tbConnection = new System.Windows.Forms.TextBox();
            this.btExecute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbEncoding = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBytes = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lbBytes = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEncodings = new System.Windows.Forms.ComboBox();
            this.btnFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResponse
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.tbResponse, 4);
            this.tbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResponse.Location = new System.Drawing.Point(3, 49);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResponse.Size = new System.Drawing.Size(639, 59);
            this.tbResponse.TabIndex = 0;
            // 
            // tbPostBody
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbPostBody, 2);
            this.tbPostBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPostBody.Location = new System.Drawing.Point(3, 46);
            this.tbPostBody.Multiline = true;
            this.tbPostBody.Name = "tbPostBody";
            this.tbPostBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPostBody.Size = new System.Drawing.Size(639, 84);
            this.tbPostBody.TabIndex = 9;
            this.tbPostBody.Text = resources.GetString("tbPostBody.Text");
            // 
            // lbPostBody
            // 
            this.lbPostBody.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbPostBody, 2);
            this.lbPostBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPostBody.Location = new System.Drawing.Point(3, 0);
            this.lbPostBody.Name = "lbPostBody";
            this.lbPostBody.Size = new System.Drawing.Size(639, 20);
            this.lbPostBody.TabIndex = 6;
            this.lbPostBody.Text = "Body";
            // 
            // tbContentType
            // 
            this.tbContentType.Location = new System.Drawing.Point(207, 6);
            this.tbContentType.Name = "tbContentType";
            this.tbContentType.Size = new System.Drawing.Size(207, 20);
            this.tbContentType.TabIndex = 4;
            this.tbContentType.Text = "application/x-www-form-urlencoded";
            // 
            // tbTA
            // 
            this.tbTA.Location = new System.Drawing.Point(512, 7);
            this.tbTA.Name = "tbTA";
            this.tbTA.Size = new System.Drawing.Size(118, 20);
            this.tbTA.TabIndex = 8;
            this.tbTA.Text = "30000";
            // 
            // tbMethod
            // 
            this.tbMethod.Location = new System.Drawing.Point(55, 6);
            this.tbMethod.Name = "tbMethod";
            this.tbMethod.Size = new System.Drawing.Size(67, 20);
            this.tbMethod.TabIndex = 2;
            this.tbMethod.Text = "POST";
            // 
            // lbTA
            // 
            this.lbTA.AutoSize = true;
            this.lbTA.Location = new System.Drawing.Point(420, 10);
            this.lbTA.Name = "lbTA";
            this.lbTA.Size = new System.Drawing.Size(86, 13);
            this.lbTA.TabIndex = 7;
            this.lbTA.Text = "TimeOut (mSec):";
            // 
            // lbContentType
            // 
            this.lbContentType.AutoSize = true;
            this.lbContentType.Location = new System.Drawing.Point(128, 9);
            this.lbContentType.Name = "lbContentType";
            this.lbContentType.Size = new System.Drawing.Size(74, 13);
            this.lbContentType.TabIndex = 3;
            this.lbContentType.Text = "Content Type:";
            // 
            // lbMethod
            // 
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(3, 10);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(46, 13);
            this.lbMethod.TabIndex = 1;
            this.lbMethod.Text = "Method:";
            // 
            // tbConnection
            // 
            this.tbConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConnection.Location = new System.Drawing.Point(3, 23);
            this.tbConnection.Multiline = true;
            this.tbConnection.Name = "tbConnection";
            this.tbConnection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConnection.Size = new System.Drawing.Size(489, 34);
            this.tbConnection.TabIndex = 5;
            this.tbConnection.Text = "http://localhost:9000/XapianServer/Service/Ready";
            // 
            // btExecute
            // 
            this.btExecute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExecute.Location = new System.Drawing.Point(498, 23);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(144, 31);
            this.btExecute.TabIndex = 14;
            this.btExecute.Text = "Execute";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbConnection, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btExecute, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tbTA);
            this.panel1.Controls.Add(this.tbContentType);
            this.panel1.Controls.Add(this.lbMethod);
            this.panel1.Controls.Add(this.tbMethod);
            this.panel1.Controls.Add(this.lbContentType);
            this.panel1.Controls.Add(this.lbTA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 34);
            this.panel1.TabIndex = 15;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(645, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lbPostBody, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbEncoding, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbPostBody, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 133);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbEncoding
            // 
            this.lbEncoding.AutoSize = true;
            this.lbEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEncoding.Location = new System.Drawing.Point(3, 20);
            this.lbEncoding.Name = "lbEncoding";
            this.lbEncoding.Size = new System.Drawing.Size(64, 23);
            this.lbEncoding.TabIndex = 12;
            this.lbEncoding.Text = "Encoding:";
            this.lbEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 236);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(645, 3);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Response";
            // 
            // tbBytes
            // 
            this.tbBytes.Location = new System.Drawing.Point(283, 23);
            this.tbBytes.Name = "tbBytes";
            this.tbBytes.ReadOnly = true;
            this.tbBytes.Size = new System.Drawing.Size(143, 20);
            this.tbBytes.TabIndex = 18;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Location = new System.Drawing.Point(3, 20);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(82, 28);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Repeat count:";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(91, 23);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(85, 20);
            this.tbCount.TabIndex = 11;
            this.tbCount.Text = "1";
            // 
            // lbBytes
            // 
            this.lbBytes.AutoSize = true;
            this.lbBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBytes.Location = new System.Drawing.Point(223, 20);
            this.lbBytes.Name = "lbBytes";
            this.lbBytes.Size = new System.Drawing.Size(54, 26);
            this.lbBytes.TabIndex = 17;
            this.lbBytes.Text = "Bytes:";
            this.lbBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(3, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 26);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(63, 23);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(126, 20);
            this.tbTime.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tbBytes, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbBytes, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTime, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbTime, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbResponse, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 290);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 111);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tbCount, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblCount, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 239);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(645, 48);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repeating";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 287);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(645, 3);
            this.splitter3.TabIndex = 13;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(0, 401);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(645, 3);
            this.splitter4.TabIndex = 14;
            this.splitter4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFiles);
            this.panel3.Controls.Add(this.cbEncodings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(70, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 23);
            this.panel3.TabIndex = 13;
            // 
            // cbEncodings
            // 
            this.cbEncodings.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbEncodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodings.FormattingEnabled = true;
            this.cbEncodings.Location = new System.Drawing.Point(0, 0);
            this.cbEncodings.Name = "cbEncodings";
            this.cbEncodings.Size = new System.Drawing.Size(115, 21);
            this.cbEncodings.Sorted = true;
            this.cbEncodings.TabIndex = 15;
            // 
            // btnFiles
            // 
            this.btnFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiles.Location = new System.Drawing.Point(500, 0);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(75, 23);
            this.btnFiles.TabIndex = 16;
            this.btnFiles.Text = "Files";
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // HttpTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HttpTestControl";
            this.Size = new System.Drawing.Size(645, 453);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox tbPostBody;
        private System.Windows.Forms.Label lbPostBody;
        private System.Windows.Forms.TextBox tbConnection;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.TextBox tbContentType;
        private System.Windows.Forms.TextBox tbMethod;
        private System.Windows.Forms.Label lbContentType;
        private System.Windows.Forms.Label lbMethod;
        private System.Windows.Forms.TextBox tbTA;
        private System.Windows.Forms.Label lbTA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEncoding;
        private System.Windows.Forms.Label lbBytes;
        private System.Windows.Forms.TextBox tbBytes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.ComboBox cbEncodings;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
