using System;
using System.Collections.Generic;
using System.Xml;

namespace Minecraft_Server_QQ.Config
{
    class Config_read
    {
        /// <summary>
        /// 读取服务器列表
        /// </summary>
        /// <param name="path">文件(包含路径)</param>
        public void read_server(string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(path);
            XmlNodeList nodeList = xmldoc.SelectSingleNode("config").ChildNodes;
            Config_file.server_list.Clear();
            foreach (XmlNode xn in nodeList)//遍历所有子节点
            {
                XmlNode server_name = xn.SelectSingleNode("服务器名字");
                XmlNode server_local = xn.SelectSingleNode("服务端路径");
                XmlNode server_core = xn.SelectSingleNode("服务端核心");
                XmlNode server_arg = xn.SelectSingleNode("服务器参数");
                XmlNode java_local = xn.SelectSingleNode("JAVA路径");
                XmlNode java_arg = xn.SelectSingleNode("JAVA参数");
                XmlNode auto_restart = xn.SelectSingleNode("自动重启");
                XmlNode open_start = xn.SelectSingleNode("开软件启动");
                XmlNode max_m = xn.SelectSingleNode("最大内存");
                XmlNode min_m = xn.SelectSingleNode("最小内存");
                if (server_name != null && server_core != null && server_local != null
                    && server_arg != null && java_local != null)
                {
                    Config_class server = new Config_class();
                    if (Config_file.server_list.ContainsKey(server_name.InnerText) == false)
                    {
                        server.server_name = server_name.InnerXml;
                        server.server_local = server_local.InnerXml;
                        server.server_core = server_core.InnerXml;
                        server.server_arg = server_arg.InnerXml;
                        server.java_local = java_local.InnerXml;
                        server.java_arg = java_arg.InnerXml;
                        server.auto_restart = auto_restart.InnerText == "开" ? true : false;
                        server.open_start = open_start.InnerText == "开" ? true : false;
                        int.TryParse(max_m.InnerText, out server.max_m);
                        int.TryParse(min_m.InnerText, out server.min_m);
                        Config_file.server_list.Add(server.server_name, server);
                    }
                }
            }
        }
    }
}
