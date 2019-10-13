using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft_Server_QQ.Config
{
    class Server_Config
    {
        /// <summary>
        /// 服务器名字
        /// </summary>
        public string server_name;
        /// <summary>
        /// 服务端路径
        /// </summary>
        public string server_local;
        /// <summary>
        /// 服务端核心名字
        /// </summary>
        public string server_core;
        /// <summary>
        /// 服务器参数
        /// </summary>
        public string server_arg = "nogui";

        /// <summary>
        /// JAVA路径
        /// </summary>
        public string java_local;
        /// <summary>
        /// JAVA参数
        /// </summary>
        public string java_arg = "-server";

        /// <summary>
        /// 崩溃自动启动
        /// </summary>
        public bool auto_restart = false;
        /// <summary>
        /// 开启软件自动启动
        /// </summary>
        public bool open_start = false;

        /// <summary>
        /// 最大内存
        /// </summary>
        public int max_m = 1024;
        /// <summary>
        /// 最小内存
        /// </summary>
        public int min_m = 512;

    }
    class Server_Save 
    {
        /// <summary>
        /// 窗体
        /// </summary>
        public Form form;
        /// <summary>
        /// 这个对象负责核心的开服，回显文本等
        /// </summary>
        public MCServer Server;
        /// <summary>
        /// 计划任务对象
        /// </summary>
        public MCSTask Task_list;
        /// <summary>
        /// 服务器配置储存
        /// </summary>
        public Server_Config Config;
    }
}
