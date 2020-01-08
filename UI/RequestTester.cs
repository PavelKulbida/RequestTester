using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using BI;

namespace UI
{
    public partial class RequestTester : UserControl, IRequestTesterMediator
    {       
        public RequestTester()
        {
            InitializeComponent();

            tbLogPath.Text = getDefaultLogPatch();
        }


        public string getSqlRequest()
        {
            return sqlTesterControl.SQLRequest;
        }

        public SqlDataReader ExecuteSqlRequest(string reqest)
        {
            return sqlTesterControl.ExecuteSqlRequest(reqest);
        }

        public string SendRequest(string commandJSon)
        {
            return httpTestControl.SendRequest(commandJSon);
        }

        public void LogOperation(string dataBuf)
        {
            String bufTrcFileName = tbLogPath.Text +
                                    String.Format("{0:yyyyMMdd}", DateTime.Now) + ".log";

            hlpTrace trcPrc = new hlpTrace(bufTrcFileName);
            
            
            trcPrc.WriteINF(dataBuf);
        }

        public void SaveSettings()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (0 == config.AppSettings.Settings.Count)
            {
                config.AppSettings.Settings.Add("WEB.Url", httpTestControl.Url);
                config.AppSettings.Settings.Add("WEB.PostBody", httpTestControl.PostBody);
                config.AppSettings.Settings.Add("WEB.RepCount", httpTestControl.RepCount.ToString());
                config.AppSettings.Settings.Add("WEB.Encoding", httpTestControl.EncoderName);
                config.AppSettings.Settings.Add("WEB.Method", httpTestControl.Method);
                config.AppSettings.Settings.Add("WEB.ContentType", httpTestControl.ContentType);
                config.AppSettings.Settings.Add("WEB.TA", httpTestControl.TA);

                config.AppSettings.Settings.Add("SQL.ConnStr", sqlTesterControl.ConnStr);
                config.AppSettings.Settings.Add("SQL.Request", sqlTesterControl.SQLRequest);
                config.AppSettings.Settings.Add("SQL.RepCount", sqlTesterControl.RepCount.ToString());
                config.AppSettings.Settings.Add("SQL.TA", sqlTesterControl.TA);

                config.AppSettings.Settings.Add("SqlToWeb.RqPattern", sqlTOweb.RqPattern);
                config.AppSettings.Settings.Add("SqlToWeb.LogCount", sqlTOweb.LogCount.ToString());

                config.AppSettings.Settings.Add("Logger.Path", tbLogPath.Text);
                config.AppSettings.Settings.Add("Notepad.Text", tbNotes.Text);

                config.Save(ConfigurationSaveMode.Full);
            }
            else
            {
                config.AppSettings.Settings["WEB.Url"].Value = httpTestControl.Url;
                config.AppSettings.Settings["WEB.PostBody"].Value = httpTestControl.PostBody;
                config.AppSettings.Settings["WEB.RepCount"].Value = httpTestControl.RepCount.ToString();
                config.AppSettings.Settings["WEB.Encoding"].Value = httpTestControl.EncoderName;
                config.AppSettings.Settings["WEB.Method"].Value = httpTestControl.Method;
                config.AppSettings.Settings["WEB.ContentType"].Value = httpTestControl.ContentType;
                config.AppSettings.Settings["WEB.TA"].Value = httpTestControl.TA;

                config.AppSettings.Settings["SQL.ConnStr"].Value = sqlTesterControl.ConnStr;
                config.AppSettings.Settings["SQL.Request"].Value = sqlTesterControl.SQLRequest;
                config.AppSettings.Settings["SQL.RepCount"].Value = sqlTesterControl.RepCount.ToString();
                config.AppSettings.Settings["SQL.TA"].Value = sqlTesterControl.TA;

                config.AppSettings.Settings["SqlToWeb.RqPattern"].Value = sqlTOweb.RqPattern;
                config.AppSettings.Settings["SqlToWeb.LogCount"].Value = sqlTOweb.LogCount.ToString();

                config.AppSettings.Settings["Logger.Path"].Value = tbLogPath.Text;
                config.AppSettings.Settings["Notepad.Text"].Value = tbNotes.Text;

                config.Save(ConfigurationSaveMode.Modified);
            }

            ConfigurationManager.RefreshSection("appSettings");

        }

        public void LoadSettings()
        {
            sqlTOweb.SetMediator(this);
            
            if (15 <= ConfigurationManager.AppSettings.Count)
            {
                httpTestControl.Url = ConfigurationManager.AppSettings["WEB.Url"];
                httpTestControl.PostBody = ConfigurationManager.AppSettings["WEB.PostBody"];
                httpTestControl.RepCount = Convert.ToInt32(ConfigurationManager.AppSettings["WEB.RepCount"]);
                httpTestControl.EncoderName = ConfigurationManager.AppSettings["WEB.Encoding"];
                httpTestControl.Method = ConfigurationManager.AppSettings["WEB.Method"];
                httpTestControl.ContentType = ConfigurationManager.AppSettings["WEB.ContentType"];
                httpTestControl.TA = ConfigurationManager.AppSettings["WEB.TA"];

                sqlTesterControl.ConnStr = ConfigurationManager.AppSettings["SQL.ConnStr"];
                sqlTesterControl.SQLRequest = ConfigurationManager.AppSettings["SQL.Request"];
                sqlTesterControl.RepCount = Convert.ToInt32(ConfigurationManager.AppSettings["SQL.RepCount"]);
                sqlTesterControl.TA = ConfigurationManager.AppSettings["SQL.TA"];

                sqlTOweb.RqPattern = ConfigurationManager.AppSettings["SqlToWeb.RqPattern"];
                sqlTOweb.LogCount = Convert.ToInt32(ConfigurationManager.AppSettings["SqlToWeb.LogCount"]);

                string buf = ConfigurationManager.AppSettings["Logger.Path"];
                if (!string.IsNullOrEmpty(buf))
                {
                    tbLogPath.Text = buf;
                }
                else
                {
                    tbLogPath.Text = getDefaultLogPatch();
                }

                buf = ConfigurationManager.AppSettings["Notepad.Text"];
                if (!string.IsNullOrEmpty(buf))
                {
                    tbNotes.Text = buf;
                }
            }
        }

        private string getDefaultLogPatch()
        {
            return Application.StartupPath + @"\";
        }

        private void tbLogPath_TextChanged(object sender, EventArgs e)
        {
            if (0 == tbLogPath.Text.Length)
            {
                tbLogPath.Text = getDefaultLogPatch();
            }
        }

        public void StartProcess()
        {
            sqlTOweb.StartProcess();
        }

        public void StartWebProcess()
        {
            httpTestControl.StartProcess();
        }

        public void StartSqlProcess()
        {
            sqlTesterControl.StartProcess();
        }

    }
}
