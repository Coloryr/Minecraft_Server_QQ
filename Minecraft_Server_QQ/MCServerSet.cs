using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    //服务器设置相关类，用在propertyGrid控件上
    class MCServerSet
    {
        /// <summary>
        /// 主城保护范围（格）
        /// </summary>
        public int spawn_protection = 16;
        /// <summary>
        /// 最大tick
        /// </summary>
        public int max_tick_time = 60000;
        /// <summary>
        /// query端口
        /// </summary>
        public int query_port = 25565;
        /// <summary>
        /// 生成器设置
        /// </summary>
        public string generator_settings;
        /// <summary>
        /// 强制游戏模式
        /// </summary>
        public bool force_gamemode = false;
        /// <summary>
        /// 是否开启地狱
        /// </summary>
        public bool allow_nether = true;
        /// <summary>
        /// 是否启用强制白名单
        /// </summary>
        public bool enforce_whitelist = false;
        /// <summary>
        /// 游戏模式
        /// </summary>
        public int gamemode = 0;
        /// <summary>
        /// 广播控制台消息到op
        /// </summary>
        public bool broadcast_console_to_ops = true;
        /// <summary>
        /// 是否启用query
        /// </summary>
        public bool enable_query = false;
        /// <summary>
        /// 玩家挂机踢出时间
        /// </summary>
        public int player_idle_timeout = 0;
        /// <summary>
        /// 难度
        /// </summary>
        public int difficulty = 0;
        /// <summary>
        /// 是否生成怪物
        /// </summary>
        public bool spawn_monsters = true;
        /// <summary>
        /// 广播rcon消息至op
        /// </summary>
        public bool broadcast_rcon_to_ops = true;
        /// <summary>
        /// op权限等级
        /// </summary>
        public int op_permission_level = 4;
        /// <summary>
        /// 是否开启PVP
        /// </summary>
        public bool pvp = true;
        /// <summary>
        /// 是否启用监听
        /// </summary>
        public bool snooper_enabled = true;
        /// <summary>
        /// 世界类型
        /// </summary>
        public string level_type = "default";
        /// <summary>
        /// 是否启用困难模式
        /// </summary>
        public bool hardcore = false;
        /// <summary>
        /// 是否启用命令方块
        /// </summary>
        public bool enable_command_block = false;
        /// <summary>
        /// 最大玩家数量
        /// </summary>
        public int max_players = 20;
        /// <summary>
        /// 网络压包大小
        /// </summary>
        public int network_compression_threshold = 0;
        /// <summary>
        /// 资源包
        /// </summary>
        public string resource_pack_sha1;
        /// <summary>
        /// 最大世界尺寸
        /// </summary>
        public int max_world_size = 29999984;
        /// <summary>
        /// rcon端口
        /// </summary>
        public int rcon_port = 25575;
        /// <summary>
        /// 服务器端口
        /// </summary>
        public int server_port = 25565;
        /// <summary>
        /// 是否启用调试模式
        /// </summary>
        public bool debug = false;
        /// <summary>
        /// 服务器IP
        /// </summary>
        public string server_ip;
        /// <summary>
        /// 是否生成NPC
        /// </summary>
        public bool spawn_npcs = true;
        /// <summary>
        /// 是否允许飞行
        /// </summary>
        public bool allow_flight = false;
        /// <summary>
        /// 世界名字
        /// </summary>
        public string level_name = "world";
        /// <summary>
        /// 视距
        /// </summary>
        public int view_distance = 10;
        /// <summary>
        /// 资源包
        /// </summary>
        public string resource_pack;
        /// <summary>
        /// 是否生成动物
        /// </summary>
        public bool spawn_animals = true;
        /// <summary>
        /// 是否开启白名单
        /// </summary>
        public bool white_list = false;
        /// <summary>
        /// rcon密码
        /// </summary>
        public string rcon_password;
        /// <summary>
        /// 是否生成结构
        /// </summary>
        public bool generate_structures = true;
        /// <summary>
        /// 是否启用正版验证
        /// </summary>
        public bool online_mode = false;
        /// <summary>
        /// 最大建筑高度
        /// </summary>
        public int max_build_height = 256;
        /// <summary>
        /// 地图种子
        /// </summary>
        public string level_seed;
        /// <summary>
        /// 是否使用本地传送
        /// </summary>
        public bool use_native_transport = true;
        /// <summary>
        /// 是否保护链接端口
        /// </summary>
        public bool prevent_proxy_connections = false;
        /// <summary>
        /// motd内容
        /// </summary>
        public string motd = "A Minecraft Server";
        /// <summary>
        /// 是否启用rcon
        /// </summary>
        public bool enable_rcon = false;

        /*
        [Category("保护设置"), Description("保护出生点的一部分区域不受破坏，设置0为关闭")]
        public int 主城保护范围
        {//allow-nethe
            get { return spawn_protection; }
            set { spawn_protection = value; }
        }
        [Category("服务器设置"), Description("允许飞行模式，True为允许，False为不允许。")]
        public bool 允许飞行模式
        {//allow-flight
            get { return allowflight; }
            set { allowflight = value; }
        }
        [Category("服务器设置"), Description("服务器端口，应当是0~65535中间的数字")]
        public UInt16 服务器端口
        {//server-port
            get { return serverport; }
            set { serverport = value; }
        }
        [Category("服务器设置"), Description("开启超平坦，True是开启，False是不开启（修改后要删除地图，重生成地图才会生效）")]
        public bool 开启超平坦
        {//level-type=DEFAULT=默认 SUPERFLAT=超平坦
            get { return leveltype; }
            set { leveltype = value; }
        }
        [Category("服务器设置"), Description("地图种子，可用来生成特定的地图（修改后要删除地图，重生成地图才会生效）")]
        public string 地图种子
        {//level-seed
            get { return levelseed; }
            set { levelseed = value; }
        }
        [Category("服务器设置"), Description("最高建筑高度，当超过这个高度时无法放置方块")]
        public uint 最高建筑高度
        {//max-build-height
            get { return maxbuildheight; }
            set { maxbuildheight = value; }
        }
        [Category("服务器设置"), Description("是否生成NPC（村民等），True=是，False=否")]
        public bool 是否生成NPC
        {//spawn-npcs
            get { return spawnnpcs; }
            set { spawnnpcs = value; }
        }
        [Category("服务器设置"), Description("是否生成动物，True=是，False=否")]
        public bool 是否生成动物
        {//spawn-animals
            get { return spawnanimals; }
            set { spawnanimals = value; }
        }
        [Category("服务器设置"), Description("是否生成怪物，True=是，False=否")]
        public bool 是否生成怪物
        {//spawn-monsters
            get { return spawnmonsters; }
            set { spawnmonsters = value; }
        }
        [Category("服务器设置"), Description("是否生成建筑（如地牢，村庄等），True=是，False=否")]
        public bool 是否生成建筑
        {//generate-structures
            get { return generatestructures; }
            set { generatestructures = value; }
        }
        [Category("服务器设置"), Description("是否使用白名单(开启后无白名单用户无法进入服务器)，True=是，False=否")]
        public bool 是否使用白名单
        {//white-list
            get { return whitelist; }
            set { whitelist = value; }
        }
        [Category("服务器设置"), Description("是否启用正版模式(开启后非正版玩家无法进入服务器)，True=是，False=否")]
        public bool 开启正版模式
        {//online-mode
            get { return onlinemode; }
            set { onlinemode = value; }
        }
        [Category("服务器设置"), Description("是否开启PVP(玩家互相伤害)，True=是，False=否")]
        public bool 开启PVP
        {//pvp
            get { return pvp; }
            set { pvp = value; }
        }
        [Category("服务器设置"), Description("是否启用极限模式（极限模式下死亡会被服务器自动ban掉），True=是，False=否")]
        public bool 是否启用极限模式
        {//hardcore
            get { return hardcore; }
            set { hardcore = value; }
        }
        [Category("服务器设置"), Description("地图难度，0=和平模式；1=简单模式；2=普通模式；3=困难模式，不接受其他值")]
        public UInt16 地图难度
        {//difficulty
            get { return difficulty; }
            set
            {
                if (value > 3)
                {
                    MessageBox.Show("只能输入0~3！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    difficulty = value;
                }
            }
        }
        [Category("服务器设置"), Description("是否开启创造模式，True是开启，False是不开启（这里的创造是指进入服务器后的默认模式，当开启后，一个新玩家进入服务器后默认拥有创造权限，反之默认拥有生存权限）")]
        public bool 是否开启创造
        {//gamemode 0=生存 1=创造
            get { return gamemode; }
            set { gamemode = value; }
        }
        [Category("服务器设置"), Description("服务器人数限制，（软件限制最大值为65535，另外，人数与电脑配置有直接关联，并非写多少就一定能承载多少人，家用机一般可承载人数约为5人左右）")]
        public UInt16 服务器最大人数
        {//max-players
            get { return maxplayers; }
            set { maxplayers = value; }
        }
        [Category("服务器设置"), Description("motd(服务器欢迎信息，暂不支持中文)")]
        public string motd信息
        {//motd
            get { return motd; }
            set { motd = value; }
        }
        [Category("服务器设置"), Description("是否开启命令方块，True=是，False=否")]
        public bool 是否启用命令方块
        {//enable-command-block
            get { return enablecommandblock; }
            set { enablecommandblock = value; }
        }
        */
    }
}