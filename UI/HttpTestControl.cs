using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class HttpTestControl : UserControl
    {
        private readonly BI.hlpHttp httpHelper;
        
        public HttpTestControl()
        {
            InitializeComponent();

            cbEncodings.Items.Clear();

            foreach (EncodingInfo item in Encoding.GetEncodings())
            {
                cbEncodings.Items.Add(item.Name);
            }

            cbEncodings.SelectedItem = Encoding.UTF8.WebName;

            httpHelper = new BI.hlpHttp();
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            StartProcess();
        }


        public void StartProcess()
        {
            tbConnection.ReadOnly = true;
            tbCount.ReadOnly = true;
            tbPostBody.ReadOnly = true;
            tbContentType.ReadOnly = true;
            tbMethod.ReadOnly = true;

            try
            {
                int count = Convert.ToInt32(tbCount.Text);
                string bufResp = string.Empty;

                StringBuilder results = new StringBuilder();

                DateTime timeStart = DateTime.Now;

                for (int sc = 0; sc < count; sc++)
                {
                    results.Append(DateTime.Now.ToString() + " - start request " + sc.ToString());
                    results.Append(Environment.NewLine);

                    bufResp = SendRequest(tbPostBody.Text);

                    tbBytes.Text = Convert.ToString(bufResp.Length);

                    results.Append(DateTime.Now.ToString() + " - end request" + sc.ToString());
                    results.Append(Environment.NewLine);

                    results.Append(bufResp);
                    results.Append(Environment.NewLine);

                }

                DateTime timeEnd = DateTime.Now;

                TimeSpan timeDiff = timeEnd.Subtract(timeStart);
                tbTime.Text = timeDiff.ToString();

                tbResponse.Text = results.ToString();
            }
            finally
            {
                tbConnection.ReadOnly = false;
                tbCount.ReadOnly = false;
                tbPostBody.ReadOnly = false;
                tbContentType.ReadOnly = false;
                tbMethod.ReadOnly = false;
            }
        }

        public string SendRequest(string commandJSon)
        {
            string ret = string.Empty;

            httpHelper.Method = tbMethod.Text;
            httpHelper.ContentType = tbContentType.Text;
            httpHelper.Timeout = Convert.ToInt32(tbTA.Text);
            httpHelper.EncoderRequest = Encoding.GetEncoding(cbEncodings.Text);
            httpHelper.EncoderResponse = httpHelper.EncoderRequest;

            if (0 < openFileDialog.FileNames.Length)
            {
                ret = httpHelper.SendHttpFiles(tbConnection.Text, openFileDialog.FileNames);
            }
            else
            { 
                ret = httpHelper.SendPost(tbConnection.Text, commandJSon);
            }

            return ret;
        }

        public string Url 
        { 
            get
            {
                return tbConnection.Text;
            }

            set
            {
                tbConnection.Text = value;
            }
        }

        public string PostBody 
        {
            get
            {
                return tbPostBody.Text;
            }

            set
            {
                tbPostBody.Text = value;
            }
        }

        public int RepCount 
        {
            get
            {
                return Convert.ToInt32(tbCount.Text);
            }

            set
            {
                tbCount.Text = value.ToString();
            }
        }

        public string EncoderName 
        { 
            get
            {
                return (string)cbEncodings.SelectedItem;
            }

            set
            {
                cbEncodings.SelectedItem = value;
            }
        }

        public string Method 
        {
            get
            {
                return tbMethod.Text;
            }

            set
            {
                tbMethod.Text = value;
            }
        }

        public string ContentType 
        {
            get
            {
                return tbContentType.Text;
            }

            set
            {
                tbContentType.Text = value;
            }
        }

        public string TA 
        {
            get
            {
                return tbTA.Text;
            }

            set
            {
                tbTA.Text = value;
            }
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] filesList = openFileDialog.FileNames;
            StringBuilder sb = new StringBuilder();

            foreach (string f in filesList)
            {
                sb.AppendLine(f);
            }


            tbPostBody.Text = sb.ToString();
            tbPostBody.ReadOnly = true;
        }
    }
}
