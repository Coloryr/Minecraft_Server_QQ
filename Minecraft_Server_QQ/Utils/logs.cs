using System;
using System.IO;

namespace Minecraft_Server_QQ.Utils
{
    public class logs
    {
        public static string log = "logs.log";

        public static void Log_write(string a)
        {
            try
            {
                DateTime date = DateTime.Now;
                string year = date.ToShortDateString().ToString();
                string time = date.ToLongTimeString().ToString();
                string write = "[" + year + "]" + "[" + time + "]" + a;
                File.AppendAllText(Start.APP_local + log, write + Environment.NewLine);
            }
            catch 
            {

            }
        }
    }
}
