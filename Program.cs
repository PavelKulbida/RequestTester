using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace ZZ
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(UInt32 dwProcessId = 0xffffffff);

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            MainForm baseForm = new MainForm();

            if (0 < args.Length)
            {
                if ("auto" == args[0])
                {
                    baseForm.LoadSettings();

                    string type = string.Empty;
                    if (args.Length > 1)
                    {
                        type = args[1];
                    }

                    baseForm.StartProcess(type);
                }
                else if ("?" == args[0])
                {
                    AttachConsole();
                    Console.WriteLine();
                    Console.WriteLine("Help");
                    Console.WriteLine("auto - start in SQL->WEB tab");
                    Console.WriteLine("auto web - start in WEB tab");
                    Console.WriteLine("auto sql - start in SQL tab");
                }
            }
            else
            {
                Application.Run(baseForm);
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ProcessException(e.Exception, "Unhandled Thread Exception");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ProcessException((e.ExceptionObject as Exception), "Unhandled UI Exception");            
        }

        private static void ProcessException(Exception ex, string caption)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                DialogResult rez = UI.ExceptionCustomForm.Instance.ShowModal(ex, caption, ex.Message,
                                                                                "Retry", "Abort");

                if (DialogResult.Abort == rez)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                AttachConsole();
                Console.WriteLine();
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                System.Environment.Exit(1);
            }
        }

    }
}
