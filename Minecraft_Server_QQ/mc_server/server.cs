using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    class server
    {
        /// <summary>
        /// 读服务器配置文件
        /// </summary>
        /// <param name="path">文件(包含路径)</param>
        /// <param name="obj">服务器储存</param>
        public void ReadMCServerConfig(server_save server)//读取并设置服务器设置界面内容
        {
             MCconfig config = new MCconfig();
            if (!File.Exists(server.server_local + @"\server.properties"))
            {
                //如果配置文件不存在则先创建一个标准的配置文件
                config.Init(server.server_local + @"\server.properties");
                config.SetString("spawn-protection", "16");
                config.SetString("max-tick-time", "16");
                config.SetString("query.port", "");
                config.SetString("generator-settings", "");
                config.SetString("force-gamemode", "false");
                config.SetString("allow-nether", "true");
                config.SetString("enforce-whitelist", "false");
                config.SetString("gamemode", "0");
                config.SetString("broadcast-console-to-ops", "true");
                config.SetString("enable-query", "false");
                config.SetString("player-idle-timeout", "0");
                config.SetString("difficulty", "1");
                config.SetString("spawn-monsters", "true");
                config.SetString("broadcast-rcon-to-ops", "true");
                config.SetString("op-permission-level", "4");
                config.SetString("pvp", "true");
                config.SetString("snooper-enabled", "true");
                config.SetString("level-type", "default");
                config.SetString("hardcore", "false");
                config.SetString("enable-command-block", "false");
                config.SetString("max-players", "20");
                config.SetString("network-compression-threshold", "0");
                config.SetString("resource-pack-sha1", "");
                config.SetString("max-world-size", "29999984");
                config.SetString("rcon.port", "25575");
                config.SetString("server-port", "25565");
                config.SetString("debug", "false");
                config.SetString("server-ip", "");
                config.SetString("spawn-npcs", "true");
                config.SetString("allow-flighttd", "false");
                config.SetString("level-name", "world");
                config.SetString("view-distance", "10");
                config.SetString("resource-pack", "");
                config.SetString("spawn-animals", "true");
                config.SetString("white-list", "false");
                config.SetString("rcon.password", "");
                config.SetString("generate-structures", "true");
                config.SetString("online-mode", "false");
                config.SetString("max-build-height", "256");
                config.SetString("level-seed", "false");
                config.SetString("use-native-transport", "true");
                config.SetString("prevent-proxy-connections", "false");
                config.SetString("motd", "A Minecraft Server");
                config.SetString("enable-rcon", "false");
                config.UnInit(true);
            }
            
            //依次读取配置写到tmpObject对象里
            MCServerSet tmpObject = new MCServerSet();
            config.Init(server.server_local + @"\server.properties");
            tmpObject.allownethe = config.GetString("allow-nethe").ToLower() == "true" ? true : false;
            tmpObject.allowflight = config.GetString("allow-flight").ToLower() == "true" ? true : false;
            try { tmpObject.serverport = UInt16.Parse(config.GetString("server-port")); }
            catch { tmpObject.serverport = 25565; }
            if (config.GetString("level-type") == "SUPERFLAT")
                tmpObject.leveltype = true;
            else
                tmpObject.leveltype = false;
            tmpObject.levelseed = config.GetString("level-seed");
            try { tmpObject.maxbuildheight = uint.Parse(config.GetString("max-build-height")); }
            catch { tmpObject.maxbuildheight = 256; }
            tmpObject.spawnnpcs = config.GetString("spawn-npcs").ToLower() == "true" ? true : false;
            tmpObject.spawnanimals = config.GetString("spawn-animals").ToLower() == "true" ? true : false;
            tmpObject.spawnmonsters = config.GetString("spawn-monsters").ToLower() == "true" ? true : false;
            tmpObject.generatestructures = config.GetString("generate-structures").ToLower() == "true" ? true : false;
            tmpObject.whitelist = config.GetString("white-list").ToLower() == "true" ? true : false;
            tmpObject.onlinemode = config.GetString("online-mode").ToLower() == "true" ? true : false;
            tmpObject.pvp = config.GetString("pvp").ToLower() == "true" ? true : false;
            tmpObject.hardcore = config.GetString("hardcore").ToLower() == "true" ? true : false;
            try { tmpObject.difficulty = ushort.Parse(config.GetString("difficulty")); }
            catch { tmpObject.difficulty = 2; }
            tmpObject.gamemode = config.GetString("gamemode") == "1" ? true : false;
            try { tmpObject.maxplayers = ushort.Parse(config.GetString("max-players")); }
            catch { tmpObject.maxplayers = 20; }
            tmpObject.motd = config.GetString("motd");
            tmpObject.enablecommandblock = config.GetString("enable-command-block").ToLower() == "true" ? true : false;
            config.UnInit(false);
            //显示设置
            servre.form.propertyGrid1.SelectedObject = tmpObject;
            
        }
        public bool SaveMCServerConfig(server_save server)
        {
            /*
            MCServerSet tmpObj = (MCServerSet)propertyGrid1.SelectedObject;
            if (tmpObj != null)
            {
                //将修改后的配置保存到文件
                if (!Directory.Exists(Application.StartupPath + @"\server\"))
                    Directory.CreateDirectory(Application.StartupPath + @"\server\");
                #region 读取并保存配置
                MCconfig config = new MCconfig();
                config.Init(Application.StartupPath + @"\server\server.properties");
                config.SetString("allow-nethe", tmpObj.allownethe.ToString().ToLower());
                config.SetString("allow-flight", tmpObj.allowflight.ToString().ToLower());
                config.SetString("server-port", tmpObj.serverport.ToString());
                config.SetString("level-type", tmpObj.leveltype ? "SUPERFLAT" : "DEFAULT");
                config.SetString("level-seed", tmpObj.levelseed);
                config.SetString("max-build-height", tmpObj.maxbuildheight.ToString());
                config.SetString("spawn-npcs", tmpObj.spawnnpcs.ToString().ToLower());
                config.SetString("spawn-animals", tmpObj.spawnanimals.ToString().ToLower());
                config.SetString("spawn-monsters", tmpObj.spawnmonsters.ToString().ToLower());
                config.SetString("generate-structures", tmpObj.generatestructures.ToString().ToLower());
                config.SetString("white-list", tmpObj.whitelist.ToString().ToLower());
                config.SetString("online-mode", tmpObj.onlinemode.ToString().ToLower());
                config.SetString("pvp", tmpObj.pvp.ToString().ToLower());
                config.SetString("hardcore", tmpObj.hardcore.ToString().ToLower());
                config.SetString("difficulty", tmpObj.difficulty.ToString());
                config.SetString("gamemode", tmpObj.gamemode ? "1" : "0");
                config.SetString("max-players", tmpObj.maxplayers.ToString());
                config.SetString("motd", tmpObj.motd);
                config.SetString("enable-command-block", tmpObj.enablecommandblock.ToString().ToLower());
                return config.UnInit(true);
                #endregion
            }
            */
            return false;
        }
        public void ReadTaskInfo(server_save server)
        {
            /*
            //因为读取很快所以就不需要像Mod和插件哪样使用多线程了
            listView_Task.Items.Clear();
            if (Directory.Exists(Application.StartupPath + @"\Task\"))
            {
                string[] files = Directory.GetFiles(Application.StartupPath + @"\Task\", "*.ini");
                foreach (string s in files)
                {
                    string[] tmp = new string[3];
                    tmp[0] = other.GetPathFileName(s).Replace(".ini", "");
                    tmp[2] = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "time", "NULL") + "分钟";
                    string type = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "type", "-1");
                    if (type == "0")
                    {
                        //继续判断任务具体内容并翻译成中文
                        string content = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "content", "-1");
                        if (content == "0")
                            tmp[1] = "关闭服务器";
                        if (content == "1")
                            tmp[1] = "开启服务器";
                        if (content == "2")
                            tmp[1] = "重启服务器";
                        if (content == "3")
                            tmp[1] = "备份地图";
                    }
                    if (type == "1")
                        tmp[1] = "执行指定命令[" + WinAPI.GetPrivateProfileString(s, "ENCP TASK", "content", "") + "]";
                    if (tmp[1] != null)
                    {
                        ListViewItem list = new ListViewItem(tmp);
                        listView_Task.Items.Add(list);
                    }
                }
            }
            */
        }//读取计划任务并加入列表 
    }
}
