using System;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start start = new Start();
            start.Start_APP();
            Application.Run(new APP());
        }
    }
}
