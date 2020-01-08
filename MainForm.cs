using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ZZ
{
    public partial class MainForm : Form
    {
        private delegate void operationExecute();
        private readonly IDictionary<string, operationExecute> operationTable;

        public MainForm()
        {                       
            InitializeComponent();

            operationTable = new Dictionary<string, operationExecute>();
            operationTable.Add(string.Empty, requestTester.StartProcess);
            operationTable.Add("sql", requestTester.StartSqlProcess);
            operationTable.Add("web", requestTester.StartWebProcess);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            requestTester.SaveSettings();
        }

        public void StartProcess(string typeOperation)
        {
            operationExecute operBuf = null;
            operationTable.TryGetValue(typeOperation, out operBuf);

            if (null != operBuf)
            {
                operBuf();
            }
        }


        public void LoadSettings()
        {
            requestTester.LoadSettings();
        }
    }
}
