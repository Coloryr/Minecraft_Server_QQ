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
        public MCServerSet ReadMCServerConfig(server_save server)//读取并设置服务器设置界面内容
        {
            config_mcserver config = new config_mcserver();
            MCServerSet tmpObject = new MCServerSet();
            if (!File.Exists(server.server_local + @"\server.properties"))
            {
                //如果配置文件不存在则先创建一个标准的配置文件
                config.Init(server.server_local + @"\server.properties");
                config.SetString("spawn-protection", "16");
                config.SetString("max-tick-time", "60000");
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
                config.SetString("allow-flight", "false");
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
            config.Init(server.server_local + @"\server.properties");
            int.TryParse(config.GetString("spawn-protection"),out tmpObject.spawn_protection);
            int.TryParse(config.GetString("max-tick-time"), out tmpObject.max_tick_time);
            int.TryParse(config.GetString("query.port"), out tmpObject.query_port);
            tmpObject.generator_settings = config.GetString("generator-settings");
            tmpObject.force_gamemode = config.GetString("force-gamemode").ToLower() == "true" ? true : false;
            tmpObject.allow_nether = config.GetString("allow-nether").ToLower() == "true" ? true : false;
            tmpObject.enforce_whitelist = config.GetString("enforce-whitelist").ToLower() == "true" ? true : false;
            tmpObject.gamemode = config.GetString("gamemode");
            tmpObject.broadcast_console_to_ops = config.GetString("broadcast-console-to-ops").ToLower() == "true" ? true : false;
            tmpObject.enable_query = config.GetString("enable-querys").ToLower() == "true" ? true : false;
            int.TryParse(config.GetString("player-idle-timeout"), out tmpObject.player_idle_timeout);
            tmpObject.difficulty = config.GetString("difficulty");
            tmpObject.spawn_monsters = config.GetString("spawn-monsters").ToLower() == "true" ? true : false;
            tmpObject.broadcast_rcon_to_ops = config.GetString("broadcast-rcon-to-ops").ToLower() == "true" ? true : false;
            int.TryParse(config.GetString("op-permission-level"), out tmpObject.player_idle_timeout);
            tmpObject.pvp = config.GetString("pvp").ToLower() == "true" ? true : false;
            tmpObject.snooper_enabled = config.GetString("snooper-enabled").ToLower() == "true" ? true : false;
            tmpObject.level_type = config.GetString("level-type");
            tmpObject.hardcore = config.GetString("hardcore").ToLower() == "true" ? true : false;
            tmpObject.enable_command_block = config.GetString("enable-command-block").ToLower() == "true" ? true : false;
            int.TryParse(config.GetString("max-players"), out tmpObject.max_players);
            int.TryParse(config.GetString("network-compression-threshold"), out tmpObject.network_compression_threshold);
            tmpObject.resource_pack_sha1 = config.GetString("resource-pack-sha1");
            int.TryParse(config.GetString("max-world-size"), out tmpObject.max_world_size);
            int.TryParse(config.GetString("rcon.port"), out tmpObject.rcon_port);
            int.TryParse(config.GetString("server-port"), out tmpObject.server_port);
            tmpObject.debug = config.GetString("debug").ToLower() == "true" ? true : false;
            tmpObject.server_ip = config.GetString("server-ip");
            tmpObject.spawn_npcs = config.GetString("spawn-npcs").ToLower() == "true" ? true : false;
            tmpObject.allow_flight = config.GetString("allow-flight").ToLower() == "true" ? true : false;
            tmpObject.level_name = config.GetString("level-name");
            int.TryParse(config.GetString("view-distance"), out tmpObject.view_distance);
            tmpObject.resource_pack = config.GetString("resource-pack");
            tmpObject.spawn_animals = config.GetString("spawn-animals").ToLower() == "true" ? true : false;
            tmpObject.white_list = config.GetString("white-list").ToLower() == "true" ? true : false;
            tmpObject.rcon_password = config.GetString("rcon.password");
            tmpObject.generate_structures = config.GetString("generate-structures").ToLower() == "true" ? true : false;
            int.TryParse(config.GetString("max-build-height"), out tmpObject.max_build_height);
            tmpObject.online_mode = config.GetString("online-mode").ToLower() == "true" ? true : false;
            tmpObject.level_seed = config.GetString("level-seed");
            tmpObject.use_native_transport = config.GetString("use-native-transport").ToLower() == "true" ? true : false;
            tmpObject.prevent_proxy_connections = config.GetString("prevent-proxy-connections").ToLower() == "true" ? true : false;
            tmpObject.enable_rcon = config.GetString("enable-rcon").ToLower() == "true" ? true : false;
            tmpObject.motd = config.GetString("motd");

            config.UnInit(false);
            //显示设置
            return tmpObject;

        }
        public bool SaveMCServerConfig(server_save server, MCServerSet tmpObj)
        {
            if (tmpObj != null)
            {
                config_mcserver config = new config_mcserver();
                config.Init(server.server_local + @"\server.properties");
                config.SetString("spawn-protection", tmpObj.spawn_protection.ToString());
                config.SetString("max-tick-time", tmpObj.max_tick_time.ToString());
                config.SetString("query.port", tmpObj.query_port.ToString());
                config.SetString("generator-settings", tmpObj.generator_settings);
                config.SetString("force-gamemode", tmpObj.force_gamemode.ToString());
                config.SetString("allow-nether", tmpObj.allow_nether.ToString());
                config.SetString("enforce-whitelist", tmpObj.enforce_whitelist.ToString());
                config.SetString("gamemode", tmpObj.gamemode);
                config.SetString("broadcast-console-to-ops", tmpObj.broadcast_console_to_ops.ToString());
                config.SetString("enable-query", tmpObj.enable_query.ToString());
                config.SetString("player-idle-timeout", tmpObj.player_idle_timeout.ToString());
                config.SetString("difficulty", tmpObj.difficulty);
                config.SetString("spawn-monsters", tmpObj.spawn_monsters.ToString());
                config.SetString("broadcast-rcon-to-ops", tmpObj.broadcast_rcon_to_ops.ToString());
                config.SetString("op-permission-level", tmpObj.op_permission_level.ToString());
                config.SetString("pvp", tmpObj.pvp.ToString());
                config.SetString("snooper-enabled", tmpObj.snooper_enabled.ToString());
                config.SetString("level-type", tmpObj.level_type);
                config.SetString("hardcore", tmpObj.hardcore.ToString());
                config.SetString("enable-command-block", tmpObj.enable_command_block.ToString());
                config.SetString("max-players", tmpObj.max_players.ToString());
                config.SetString("network-compression-threshold", tmpObj.network_compression_threshold.ToString());
                config.SetString("resource-pack-sha1", tmpObj.resource_pack_sha1);
                config.SetString("max-world-size", tmpObj.max_world_size.ToString());
                config.SetString("rcon.port", tmpObj.rcon_port.ToString());
                config.SetString("server-port", tmpObj.server_port.ToString());
                config.SetString("debug", tmpObj.debug.ToString());
                config.SetString("server-ip", tmpObj.server_ip);
                config.SetString("spawn-npcs", tmpObj.spawn_npcs.ToString());
                config.SetString("allow-flight", tmpObj.allow_flight.ToString()); ;
                config.SetString("level-name", tmpObj.level_name);
                config.SetString("view-distance", tmpObj.view_distance.ToString());
                config.SetString("resource-pack", tmpObj.resource_pack);
                config.SetString("spawn-animals", tmpObj.spawn_animals.ToString());
                config.SetString("white-list", tmpObj.white_list.ToString());
                config.SetString("rcon.password", tmpObj.rcon_password);
                config.SetString("generate-structures", tmpObj.generate_structures.ToString());
                config.SetString("online-mode", tmpObj.online_mode.ToString());
                config.SetString("max-build-height", tmpObj.max_build_height.ToString());
                config.SetString("level-seed", tmpObj.level_seed);
                config.SetString("use-native-transport", tmpObj.use_native_transport.ToString());
                config.SetString("prevent-proxy-connections", tmpObj.prevent_proxy_connections.ToString());
                config.SetString("motd", tmpObj.motd);
                config.SetString("enable-rcon", tmpObj.enable_rcon.ToString());
                return config.UnInit(true);
            }
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
