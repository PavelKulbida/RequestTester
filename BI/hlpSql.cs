using System;
using System.Collections.Generic;
using System.Text;

namespace BI
{
    public class hlpSql
    {
        private static volatile hlpSql instance;
        private readonly static object syncRoot = new Object();

        public static hlpSql SinglInstance
        {
            get
            {
                // DCL
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new hlpSql();
                        }
                    }
                }

                return instance;
            }
        }

        public int timeOut = 60000;

        public string SendRequest(string connStr, string requestStr)
        {
            return SendRequest(connStr, requestStr, this.timeOut);
        }

        public string SendRequest(string connStr, string requestStr, int ta)
        {
            string ret = null;

            return ret;
        }

    }
}
