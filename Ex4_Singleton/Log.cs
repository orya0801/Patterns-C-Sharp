using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ex4_Singleton
{
    class Log
    {
        static Lazy<Log> myLog = new Lazy<Log>(() => new Log());

        public static Log MyLog
        {
            get
            {
                return myLog.Value;
            }
        }

        Log() { }
        public void LogExecution(string mes)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Loger(mes, w);
                w.Close();
            }
        }

        public static void Loger(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
            w.WriteLine("Действие: {0}", logMessage);
            w.WriteLine("-------------------------------");
        }
    }
}
