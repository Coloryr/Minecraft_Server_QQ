using System.Collections.Generic;

namespace Minecraft_Server_QQ.Config
{
    class Config_file
    {
        /// <summary>
        /// 服务器列表文件
        /// </summary>
        public static string server = "server.xml";
        /// <summary>
        /// 服务器数据储存
        /// </summary>
        public static Dictionary<string, Server_Save> server_list = new Dictionary<string, Server_Save> { };
        /// <summary>
        /// 服务器配置文件储存
        /// </summary>
        public static Dictionary<string, Server_Config> server_config_list = new Dictionary<string, Server_Config> { };
    }
}
