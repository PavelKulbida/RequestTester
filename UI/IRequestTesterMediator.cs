using System.Data.SqlClient;

namespace UI
{
    public interface IRequestTesterMediator
    {
        string getSqlRequest();
        SqlDataReader ExecuteSqlRequest(string reqestBuf);
        string SendRequest(string commandJSon);
        void LogOperation(string dataBuf);
        void SaveSettings();
        void LoadSettings();
    }
}
