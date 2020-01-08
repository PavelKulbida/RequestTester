using System;
using System.Windows.Forms;


namespace UI
{
    public partial class ExceptionCustomForm : Form
    {
        #region Public

        public static ExceptionCustomForm Instance
        {
            get
            {
                return instance;
            }
        }


        public DialogResult ShowModal(Exception ex, string capt, string text, string btRetryCaption, string btAbortCaption)
        {
            exBuf = ex;
            captBuf = capt;
            textBuf = text;
            button1Caption = btRetryCaption;
            button2Caption = btAbortCaption;

            this.Visible = false;
            return this.ShowDialog();
        }

        #endregion

        #region Private

        private static ExceptionCustomForm instance;
        private Exception exBuf = null;

        private string captBuf = string.Empty;
        private string textBuf = string.Empty;
        private string button1Caption = string.Empty;
        private string button2Caption = string.Empty;

        private void CustomForm_Load(object sender, EventArgs e)
        {
        }

        private string getMessageFromExeption(Exception exBuf)
        {
            string ret = exBuf.Message;

            if (exBuf.InnerException != null)
            {
                ret = ret + " --> ";
                ret = ret + getMessageFromExeption(exBuf.InnerException);
            }

            return ret;
        }

        private void btRetry_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btAbort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }


        private ExceptionCustomForm()
        {
            InitializeComponent();
        }

        static ExceptionCustomForm()
        {
            instance = new ExceptionCustomForm();
        }

        #endregion

        private void CustomForm_Shown(object sender, EventArgs e)
        {
            if (exBuf != null)
            {
                string msgText = getMessageFromExeption(exBuf);


                textErr.Text = String.Format("{0}\r\n\r\n{1}\r\n\r\n{2}", msgText, exBuf.Source, exBuf.StackTrace);
            }

            if (captBuf != null)
            {
                lbCaption.Text = captBuf;
            }
            else
            {
                lbCaption.Text = string.Empty;
            }

            if (textBuf != null)
            {
                lbText.Text = textBuf;
            }
            else
            {
                lbText.Text = string.Empty;
            }



            if (button1Caption != null)
            {
                btRetry.Text = button1Caption;
                btRetry.Visible = true;
            }
            else
            {
                btRetry.Visible = false;
            }

            if (button2Caption != null)
            {
                btAbort.Text = button2Caption;
                btAbort.Visible = true;
            }
            else
            {
                btAbort.Visible = false;
            }
        }
    }
}
