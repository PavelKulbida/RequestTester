using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI
{
    public partial class SqlToWeb : UserControl
    {
        public SqlToWeb()
        {
            buildStr = new StringBuilder();            
            buildLog = new StringBuilder();
            
            InitializeComponent();
        }

        public void SetMediator(IRequestTesterMediator mediatorBuf)
        {
            mediatorCtrl = mediatorBuf;
        }

        public string RqPattern 
        {
            get
            {
                return tbPattern.Text;
            }

            set
            {
                tbPattern.Text = value;
            }
        }

        public int LogCount 
        {
            get
            {
                return Convert.ToInt32(tbLogWriteCount.Text);
            }
            set
            {
                tbLogWriteCount.Text = value.ToString();
            }
        }

        private IRequestTesterMediator mediatorCtrl;
        private readonly StringBuilder buildLog;
        private readonly StringBuilder buildStr;

        private void btnStart_Click(object sender, EventArgs e)
        {
            mediatorCtrl.SaveSettings();

            StartProcess();
        }

        private void ShowLog(string count, string dataBuf, string commandJSon, string rezult)
        {
            buildStr.Length = 0;

            buildStr.Append(count);
            buildStr.Append(" : ");           
            buildStr.Append(dataBuf);
            buildStr.Append("\t");
            buildStr.Append(commandJSon);
            buildStr.Append("\t");
            buildStr.Append(rezult);

            string buf = buildStr.ToString();

            buildLog.Append(DateTime.Now.ToString() + " " + buf);
            buildLog.Append(Environment.NewLine);

            mediatorCtrl.LogOperation(buf);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // (прервать поток)
        }

        private string GenerateCommand(string dataBuf)
        {
            string ret = tbPattern.Text;

            ret = ret.Replace("<<<SQL:0>>>", dataBuf);

            return ret;
        }


        public void StartProcess()
        {
            int logCount = Convert.ToInt32(tbLogWriteCount.Text);

            buildLog.Length = 0;

            // TODO: (в отдельном потоке)
            ShowLog("start", String.Empty, String.Empty, String.Empty);


            // взяли запрос
            string reqest = mediatorCtrl.getSqlRequest();


            // выполнили запрос страницы в базе
            SqlDataReader reader = mediatorCtrl.ExecuteSqlRequest(reqest);

            uint countRecord = 0;

            DateTime timeStart = DateTime.Now;

            // в цикле - загружаем на сервер 
            while (reader.Read())
            {
                try
                {
                    //взяли 0-ой столбец
                    string dataBuf = reader[0].ToString();

                    //обернули в шаблон
                    string commandJSon = GenerateCommand(dataBuf);

                    //отправили на сервер
                    string rezult = mediatorCtrl.SendRequest(commandJSon);

                    //лог
                    if ((0 != logCount) && (0 == (countRecord % logCount)))
                    {
                        ShowLog(countRecord.ToString(), dataBuf, commandJSon, rezult);
                    }

                    //обновить время и индикатор
                }
                catch (Exception ex)
                {
                    ShowLog("Exception", ex.Message, ex.Source, ex.HelpLink);
                }

                countRecord++;
            }

            DateTime timeEnd = DateTime.Now;

            TimeSpan timeDiff = timeEnd.Subtract(timeStart);
            tbTime.Text = timeDiff.ToString();


            reader.Close();

            ShowLog("end", String.Empty, String.Empty, String.Empty);

            tbLog.Text = buildLog.ToString();
        }
    }
}
