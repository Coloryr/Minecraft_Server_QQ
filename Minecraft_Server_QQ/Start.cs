using System;
using System.IO;

namespace Minecraft_Server_QQ
{
    class Start
    {
        public static string APP_local = AppDomain.CurrentDomain.BaseDirectory;
        public void Start_APP()
        {
            logs.Log_write("程序启动");
            if (!File.Exists(APP_local + config_file.server))
                XML.CreateFile(APP_local + config_file.server, 0);
            config_read config = new config_read();
            config.read_server(APP_local + config_file.server);
        }
    }
}