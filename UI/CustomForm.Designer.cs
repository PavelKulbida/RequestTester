namespace UI
{
    public partial class ExceptionCustomForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbText = new System.Windows.Forms.TextBox();
            this.lbCaption = new System.Windows.Forms.TextBox();
            this.btAbort = new System.Windows.Forms.Button();
            this.btRetry = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textErr = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbText);
            this.tabPage1.Controls.Add(this.lbCaption);
            this.tabPage1.Controls.Add(this.btAbort);
            this.tabPage1.Controls.Add(this.btRetry);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сообщение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(2, 36);
            this.lbText.Multiline = true;
            this.lbText.Name = "lbText";
            this.lbText.ReadOnly = true;
            this.lbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbText.Size = new System.Drawing.Size(519, 214);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "TEST";
            // 
            // lbCaption
            // 
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCaption.Location = new System.Drawing.Point(1, 1);
            this.lbCaption.Multiline = true;
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.ReadOnly = true;
            this.lbCaption.Size = new System.Drawing.Size(519, 29);
            this.lbCaption.TabIndex = 2;
            this.lbCaption.Text = "TEST";
            this.lbCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAbort
            // 
            this.btAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAbort.Location = new System.Drawing.Point(353, 256);
            this.btAbort.Name = "btAbort";
            this.btAbort.Size = new System.Drawing.Size(135, 29);
            this.btAbort.TabIndex = 1;
            this.btAbort.Text = "Завершить";
            this.btAbort.UseVisualStyleBackColor = true;
            this.btAbort.Click += new System.EventHandler(this.btAbort_Click);
            // 
            // btRetry
            // 
            this.btRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRetry.Location = new System.Drawing.Point(32, 256);
            this.btRetry.Name = "btRetry";
            this.btRetry.Size = new System.Drawing.Size(135, 29);
            this.btRetry.TabIndex = 0;
            this.btRetry.Text = "Повторить";
            this.btRetry.UseVisualStyleBackColor = true;
            this.btRetry.Click += new System.EventHandler(this.btRetry_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textErr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подробно";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textErr
            // 
            this.textErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textErr.Location = new System.Drawing.Point(3, 3);
            this.textErr.Multiline = true;
            this.textErr.Name = "textErr";
            this.textErr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textErr.Size = new System.Drawing.Size(515, 287);
            this.textErr.TabIndex = 0;
            this.textErr.Text = "TEXT";
            // 
            // ExceptionCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 319);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionCustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attention !";
            this.Load += new System.EventHandler(this.CustomForm_Load);
            this.Shown += new System.EventHandler(this.CustomForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btAbort;
        private System.Windows.Forms.Button btRetry;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textErr;
        private System.Windows.Forms.TextBox lbText;
        private System.Windows.Forms.TextBox lbCaption;

    }
}