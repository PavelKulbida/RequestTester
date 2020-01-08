using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class SqlTesterControl : UserControl
    {
        public SqlTesterControl()
        {
            conn = new SqlConnection();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            InitializeComponent();

            maxResultShow = 10000;
            tbMazRezShow.Text = Convert.ToString(maxResultShow);
        }

        public string ConnStr
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

        public string SQLRequest
        {
            get
            {
                return tbRequest.Text;
            }
            set
            {
                tbRequest.Text = value;
            }
        }

        public SqlDataReader ExecuteSqlRequest(string reqestBuf)
        {
            if (conn.State != ConnectionState.Open)
            {
                OpenConnect();
            }

            cmd.CommandTimeout = Convert.ToInt32(tbTA.Text);
            cmd.CommandText = reqestBuf;
            return cmd.ExecuteReader();
        }

        private readonly SqlConnection conn;
        private readonly SqlCommand cmd;
        private readonly uint maxResultShow;

        private void OpenConnect()
        {
            conn.ConnectionString = tbConnection.Text;
            conn.Open();

            tbRequest.ReadOnly = false;
            tbCount.ReadOnly = false;
            btnStartTest.Enabled = true;
            tbLog.Text = String.Empty;

            tbConnection.ReadOnly = true;
        }

        private void CloseConnect()
        {
            conn.Close();

            tbRequest.ReadOnly = true;
            tbCount.ReadOnly = true;
            btnStartTest.Enabled = false;

            tbConnection.ReadOnly = false;
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tbConnection.ReadOnly)
            {
                CloseConnect();
            }
            else
            {
                OpenConnect();
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            StartInnerProcess();
        }

        public void StartProcess()
        {
            OpenConnect();
            StartInnerProcess();
            CloseConnect();
        }


        private void StartInnerProcess()
        {
            tbRequest.ReadOnly = true;
            tbCount.ReadOnly = true;

            try
            {

                int count = Convert.ToInt32(tbCount.Text);

                StringBuilder results = new StringBuilder();

                DateTime timeStart = DateTime.Now;

                for (int sc = 0; sc < count; sc++)
                {
                    results.Append(DateTime.Now.ToString() + " - start request " + sc.ToString());
                    results.Append(Environment.NewLine);

                    SqlDataReader reader = ExecuteSqlRequest(tbRequest.Text);

                    results.Append(DateTime.Now.ToString() + " - end request" + sc.ToString());
                    results.Append(Environment.NewLine);


                    uint countShow = 0;
                    while (reader.Read() && (countShow < maxResultShow))
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);

                        countShow++;
                    }

                    reader.Close();

                    tbRezCount.Text = Convert.ToString(countShow);
                }

                DateTime timeEnd = DateTime.Now;

                TimeSpan timeDiff = timeEnd.Subtract(timeStart);
                tbTime.Text = timeDiff.ToString();

                tbLog.Text = results.ToString();
            }
            finally
            {
                tbRequest.ReadOnly = false;
                tbCount.ReadOnly = false;
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
    }
}
