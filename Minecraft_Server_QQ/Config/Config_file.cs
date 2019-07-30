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
        public static Dictionary<string, Config_class> server_list = new Dictionary<string, Config_class> { };
    }
}
