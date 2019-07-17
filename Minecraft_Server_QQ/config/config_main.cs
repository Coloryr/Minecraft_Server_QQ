using System.Collections.Generic;

namespace Minecraft_Server_QQ
{
    class config_file
    {
        /// <summary>
        /// 服务器列表文件
        /// </summary>
        public static string server = "server.xml";
        /// <summary>
        /// 服务器数据储存
        /// </summary>
        public static Dictionary<string, server_save> server_list = new Dictionary<string, server_save> { };
    }
}
