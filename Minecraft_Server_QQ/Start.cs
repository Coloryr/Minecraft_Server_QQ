using Minecraft_Server_QQ.Config;
using Minecraft_Server_QQ.Utils;
using System;
using System.IO;

namespace Minecraft_Server_QQ
{
    class Start
    {
        public static bool updata = false;
        public static bool is_close = false;
        public static string APP_local = AppDomain.CurrentDomain.BaseDirectory;
        public void Start_APP()
        {
            logs.Log_write("程序启动");
            if (!File.Exists(APP_local + Config_file.server))
                XML.CreateFile(APP_local + Config_file.server, 0);
            Config_read config = new Config_read();
            config.read_server(APP_local + Config_file.server);
            updata = true;
        }
    }
}