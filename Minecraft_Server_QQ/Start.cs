using Minecraft_Server_QQ.Config;
using Minecraft_Server_QQ.Utils;
using System;
using System.Collections.Generic;
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
            if (!File.Exists(APP_local + Config_file.server))
                XML.CreateFile(APP_local + Config_file.server, 0);
            Config_read config = new Config_read();
            config.read_server(APP_local + Config_file.server);
            
            updata = true;
        }

        public void First_Load()
        {
            if (Config_file.server_list.Count != 0)
            {
                Dictionary<string, Server_Config>.ValueCollection configs = Config_file.server_config_list.Values;
                foreach (Server_Config config in configs)
                {
                    Server_Save server = new Server_Save();
                    server.Config = config;
                    server.Server = new MCServer(server);
                    server.Task_list = new MCSTask(server);
                    server.form = new Window_Main(server);

                    Config_file.server_list.Add(server.Config.server_name, server);
                }
            }
        }
    }
}