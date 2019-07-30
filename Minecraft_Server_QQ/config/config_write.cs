using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Minecraft_Server_QQ.Config
{
    class Config_write
    {
        /// <summary>
        /// 写服务器列表
        /// </summary>
        /// <param name="path">文件(包含路径)</param>
        /// <param name="obj">服务器储存</param>
        public static void write_server(string path, Config_class obj)
        {
            if (File.Exists(path) == false)
                XML.CreateFile(path, 0);
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(path);
                ///导入XML文件
                XmlNodeList nodeList = xmldoc.SelectSingleNode("config").ChildNodes;
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    //查找服务器
                    if (xn.Name == "服务器列表")
                    {
                        XmlNode xnLurl = xn.SelectSingleNode("服务器名字");
                        if (xnLurl.InnerText == obj.server_name)
                        {
                            xnLurl = xn.SelectSingleNode("服务端路径");
                            xnLurl.InnerText = obj.server_local;
                            xnLurl = xn.SelectSingleNode("服务端核心");
                            xnLurl.InnerText = obj.server_core;
                            xnLurl = xn.SelectSingleNode("服务器参数");
                            xnLurl.InnerText = obj.server_arg;
                            xnLurl = xn.SelectSingleNode("JAVA路径");
                            xnLurl.InnerText = obj.java_local;
                            xnLurl = xn.SelectSingleNode("JAVA参数");
                            xnLurl.InnerText = obj.java_arg;
                            xnLurl = xn.SelectSingleNode("自动重启");
                            xnLurl.InnerText = obj.auto_restart ? "开" : "关";
                            xnLurl = xn.SelectSingleNode("开软件启动");
                            xnLurl.InnerText = obj.open_start ? "开" : "关";
                            xnLurl = xn.SelectSingleNode("最大内存");
                            xnLurl.InnerText = obj.max_m.ToString();
                            xnLurl = xn.SelectSingleNode("最小内存");
                            xnLurl.InnerText = obj.min_m.ToString();
                            xmldoc.Save(path);
                            return;
                        }
                    }
                }
                //根节点
                XmlElement root = xmldoc.DocumentElement;
                //子节点
                XmlElement Child;
                //保存的值
                XmlElement Text;
                Child = xmldoc.CreateElement("服务器列表");
                root.AppendChild(Child);

                Text = xmldoc.CreateElement("服务器名字");
                Text.InnerText = obj.server_name;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("服务端路径");
                Text.InnerText = obj.server_local;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("服务端核心");
                Text.InnerText = obj.server_core;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("服务器参数");
                Text.InnerText = obj.server_arg;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("JAVA路径");
                Text.InnerText = obj.java_local;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("JAVA参数");
                Text.InnerText = obj.java_arg;
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("自动重启");
                Text.InnerText = obj.auto_restart ? "开" : "关";
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("开软件启动");
                Text.InnerText = obj.open_start ? "开" : "关";
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("最大内存");
                Text.InnerText = obj.max_m.ToString();
                Child.AppendChild(Text);
                Text = xmldoc.CreateElement("最小内存");
                Text.InnerText = obj.min_m.ToString();
                Child.AppendChild(Text);

                xmldoc.Save(path);
            }
            catch (Exception)
            {
                if (MessageBox.Show("配置文件在写入时发发生了错误，是否要删除原来的配置文件再新生成一个？",
                    "配置文件错误", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    XML.CreateFile(path, 1);
                    write_server(path, obj);
                }
            }
        }
        /// <summary>
        /// 删除服务器列表
        /// </summary>
        /// <param name="path">文件(包含路径)</param>
        /// <param name="obj">服务器储存</param>
        public static void delete_server(string path, Config_class obj)
        {
            if (File.Exists(path) == false)
                XML.CreateFile(path, 0);
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(path);
                ///导入XML文件
                XmlNodeList nodeList = xmldoc.SelectSingleNode("config").ChildNodes;
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    //查找服务器
                    if (xn.Name == "服务器列表")
                    {
                        XmlNode xnLurl = xn.SelectSingleNode("服务器名字");
                        if (xnLurl.InnerText == obj.server_name)
                        {
                            XmlNode a = xmldoc.SelectSingleNode("config");
                            a.RemoveChild(xn);
                            xmldoc.Save(path);
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}