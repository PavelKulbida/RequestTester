#define TRACE

using System;
using System.Diagnostics;

namespace BI
{
    /// <summary>
    /// System Tracer Facade
    /// Kulbida P.A. 2009
    /// </summary>
    public class hlpTrace
    {
        private static volatile hlpTrace instance;
        private readonly static object syncRoot = new Object();

        public static hlpTrace SinglInstance
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
                            instance = new hlpTrace();
                        }
                    }
                }

                return instance;
            }
        }
        
        public string patchB
        {
            get
            {
                return patchBase;
            }
            set
            {
                patchBase = value;
                UpdateLogFile();
            }
        }

        public hlpTrace()
        {
            patchBase = string.Empty;
        }

        public hlpTrace(string basePatch)
        {
            patchBase = basePatch;
            UpdateLogFile();
        }


        public void WriteStr(String msg)
        {
            Trace.WriteLine(msg);
            Trace.Close();
        }

        public void WriteEXPT(Exception ex)
        {
            WriteStr(DateTime.Now + " EXPT: \"" + ex.Message + "\r\n" + ex.StackTrace + "\"");
        }

        public void WriteINF(String msg)
        {
            WriteStr(DateTime.Now + " INF: \"" + msg + "\"");
        }

        public void WriteOUT(String msg)
        {
            WriteStr(DateTime.Now + " OUT: \"" + msg + "\"");
        }

        public void WriteIN(String msg)
        {
            WriteStr(DateTime.Now + " IN: \"" + msg + "\"");
        }


        private void UpdateLogFile()
        {
            if (patchBase != string.Empty)
            {
                Trace.Listeners.Clear();
                var textListener = new TextWriterTraceListener(patchBase);
                Trace.Listeners.Add(textListener);
                Trace.AutoFlush = true;
            }
        }

        private string patchBase;
    }

}
