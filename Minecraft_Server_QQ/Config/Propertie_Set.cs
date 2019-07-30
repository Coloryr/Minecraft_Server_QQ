using System.ComponentModel;

namespace Minecraft_Server_QQ.Config
{
    //服务器设置相关类，用在propertyGrid控件上
    class Propertie_Set
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
        public string gamemode = "survival";
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
        /// 游戏难度
        /// </summary>
        public string difficulty = "0";
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
        /// 是否启用极限模式
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
        /// 资源包的SHA-1值
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

        [Category("保护设置"), Description("通过将该值进行(x*2)+1的运算来决定出生点的保护半径。设置为0将不会禁用出生点保护。设置为0将会保护位于出生点的1x1方块区域，设置为1将会保护以出生点为中心的3x3方块区域。设置为2会保护5x5的方块区域，设置为3将会保护7x7的方块区域，以此类推。 这个选项只会在第一个玩家进行服务器时生成。如果服务器没有设置OP，这个选项将会自动禁用。")]
        public int 主城保护范围
        {
            get { return spawn_protection; }
            set { spawn_protection = 主城保护范围; }
        }
        [Category("服务器设置"), Description("设置每个tick花费的最大毫秒数，超过该最大毫秒数看门狗将停止服务器程序并附带上一些信息。正常情况下服务器的一个tick最大会花费60.00秒（最小应该为0.05秒）；如果服务器程序被判定为崩溃了，它将被强制终止运行。")]
        public int 最大游戏tick
        {
            get { return max_tick_time; }
            set { max_tick_time = 最大游戏tick; }
        }
        [Category("query设置"), Description("设置监听服务器的端口号")]
        public int query端口
        {
            get { return query_port; }
            set { query_port = query端口; }
        }
        [Category("生成器设置"), Description("用于自定义超平坦世界的生成")]
        public string 生成器设置
        {
            get { return generator_settings; }
            set { generator_settings = 生成器设置; }
        }
        [Category("服务器设置"), Description("强制玩家加入时为默认游戏模式，false - 玩家将以退出前的游戏模式加入，true - 玩家总是以默认游戏模式加入")]
        public bool 强制游戏模式
        {
            get { return force_gamemode; }
            set { force_gamemode = 强制游戏模式; }
        }
        [Category("生成器设置"), Description("允许玩家进入下界。false - 下界传送门不会生效。true - 玩家可以通过下界传送门前往下界。")]
        public bool 是否开启地狱
        {
            get { return allow_nether; }
            set { allow_nether = 是否开启地狱; }
        }
        [Category("服务器设置"), Description("是否启用强制白名单")]
        public bool 是否启用强制白名单
        {
            get { return enforce_whitelist; }
            set { enforce_whitelist = 是否启用强制白名单; }
        }
        [Category("服务器设置"), Description("定义默认游戏模式，1.12.2及以前请用数字")]
        public string 游戏模式
        {
            get { return gamemode; }
            set { gamemode = 游戏模式; }
        }
        [Category("服务器设置"), Description("广播控制台消息到op")]
        public bool 广播控制台消息到op
        {
            get { return broadcast_console_to_ops; }
            set { broadcast_console_to_ops = 广播控制台消息到op; }
        }
        [Category("query设置"), Description("允许使用GameSpy4协议的服务器监听器。它被用于收集服务器信息。")]
        public bool 是否启用query
        {
            get { return enable_query; }
            set { enable_query = 是否启用query; }
        }
        [Category("服务器设置"), Description("如果不为0，服务器将在玩家的空闲时间达到设置的时间（单位为分钟）时将玩家踢出服务器")]
        public int 玩家挂机踢出时间
        {
            get { return player_idle_timeout; }
            set { player_idle_timeout = 玩家挂机踢出时间; }
        }
        [Category("服务器设置"), Description("定义服务器的游戏难度（例如生物对玩家造成的伤害，饥饿与中毒对玩家的影响方式等）。1.12.2及以下请用数字")]
        public string 游戏难度
        {
            get { return difficulty; }
            set { difficulty = 游戏难度; }
        }
        [Category("生成器设置"), Description("决定攻击型生物（怪兽）是否可以生成。true - 可以。只要满足条件的话怪物就会生成。false - 禁用。不会有任何怪物。如果difficulty = 0（和平）的话，本属性值不会有任何影响。")]
        public bool 是否生成怪物
        {
            get { return spawn_monsters; }
            set { spawn_monsters = 是否生成怪物; }
        }
        [Category("rcon设置"), Description("广播rcon消息至op")]
        public bool 广播rcon消息至op
        {
            get { return broadcast_rcon_to_ops; }
            set { broadcast_rcon_to_ops = 广播rcon消息至op; }
        }
        [Category("服务器设置"), Description("设定OP的权限等级：1 - OP可以无视重生点保护。2 - OP可以使用单人游戏作弊命令（除了 /publish，因为不能在服务器上使用，/debug也是）并使用命令方块。命令方块和领域服服主/管理员有此等级权限。3 - OP可以使用几乎所有多人游戏限定的命令（除第4级专用命令）4 - OP可以使用所有命令，包括 /stop、/save-all、/save-on和 /save-off。")]
        public int op权限等级
        {
            get { return op_permission_level; }
            set { op_permission_level = op权限等级; }
        }
        [Category("服务器设置"), Description("是否允许PvP。玩家自己的箭也只有在允许PvP时才可能伤害到自己。")]
        public bool 是否开启PVP
        {
            get { return pvp; }
            set { pvp = 是否开启PVP; }
        }
        [Category("服务器设置"), Description("自1.3正式版之后，一旦启用，将允许服务端定期发送统计数据到http://snoop.minecraft.net.")]
        public bool 是否启用监听
        {
            get { return snooper_enabled; }
            set { snooper_enabled = 是否启用监听; }
        }
        [Category("生成器设置"), Description("确定地图所生成的类型，DEFAULT - 标准的世界带有丘陵，河谷，海洋等，FLAT - 一个没有特色的平坦世界，适合用于建设，LARGEBIOMES - 如同预设世界，但所有生态系都更大（仅快照12w19a，或正式版1.3之后可用），AMPLIFIED - 如同预设世界，但世界生成高度提高（仅快照13w36a，或正式版1.7.2之后可用），CUSTOMIZED - 自快照14w21b以來，服务器也支持自定义地形。使用方法是在generator - settings贴上代码。")]
        public string 世界类型
        {
            get { return level_type; }
            set { level_type = 世界类型; }
        }
        [Category("生成器设置"), Description("一旦启用，玩家在死后会自动被服务器封禁（即开启极限模式）。")]
        public bool 是否启用极限模式
        {
            get { return hardcore; }
            set { hardcore = 是否启用极限模式; }
        }
        [Category("服务器设置"), Description("是否启用命令方块")]
        public bool 是否启用命令方块
        {
            get { return enable_command_block; }
            set { enable_command_block = 是否启用命令方块; }
        }
        [Category("服务器设置"), Description("服务器同时能容纳的最大玩家数量。但请注意在线玩家越多，对服务器造成的负担也就越大。")]
        public int 最大玩家数量
        {
            get { return max_players; }
            set { max_players = 最大玩家数量; }
        }
        [Category("服务器设置"), Description("默认会允许n-1字节的数据包正常发送, 如果数据包为 n 字节或更大时会进行压缩。 所以，更低的数值会使得更多的数据包被压缩，但是如果被压缩的数据包字节太小将会得不偿失。-1 - 永久禁用数据包压缩，0 - 压缩全部数据包")]
        public int 网络压包大小
        {
            get { return network_compression_threshold; }
            set { network_compression_threshold = 网络压包大小; }
        }
        [Category("服务器设置"), Description("资源包的SHA-1值，必须为小写十六进制，建议填写它，这还没有用于验证资源包的完整性，但是它提高了资源包缓存的有效性和可靠性。")]
        public string 资源包SHA1
        {
            get { return resource_pack_sha1; }
            set { resource_pack_sha1 = 资源包SHA1; }
        }
        [Category("服务器设置"), Description("设置世界边界的最大半径值，单位为方块。通过成功执行的命令能把世界边界设置得更大，但不会超过这里设置的最大方块限制。如果设置的 max-world-size 超过默认值的大小，那将不会起任何效果。")]
        public int 最大世界尺寸
        {
            get { return max_world_size; }
            set { max_world_size = 最大世界尺寸; }
        }
        [Category("rcon设置"), Description("rcon端口")]
        public int rcon端口
        {
            get { return rcon_port; }
            set { rcon_port = rcon端口; }
        }
        [Category("服务器设置"), Description("改变服务器端口号。如果服务器通过路由器与外界连接的话，该端口必须也能够通过路由器。")]
        public int 服务器端口
        {
            get { return server_port; }
            set { server_port = 服务器端口; }
        }
        [Category("服务器设置"), Description("是否启用调试模式")]
        public bool 是否启用调试模式
        {
            get { return debug; }
            set { debug = 是否启用调试模式; }
        }
        [Category("服务器设置"), Description("将服务器与一个特定IP绑定。强烈建议你留空本属性值！")]
        public string 服务器IP
        {
            get { return server_ip; }
            set { server_ip = 服务器IP; }
        }
        [Category("服务器设置"), Description("决定是否生成村民。")]
        public bool 是否生成NPC
        {
            get { return spawn_npcs; }
            set { spawn_npcs = 是否生成NPC; }
        }
        [Category("服务器设置"), Description("允许玩家在安装添加飞行功能的 mod 前提下在生存模式下飞行。允许飞行可能会使恶意破坏者更加常见，因为此设定会使他们更容易达成目的。在创造模式下本属性不会有任何作用。")]
        public bool 是否允许飞行
        {
            get { return allow_flight; }
            set { allow_flight = 是否允许飞行; }
        }
        [Category("生成器设置"), Description("“level-name”的值将作为世界名称及其文件夹名。你也可以把你已生成的世界存档复制过来，然后让这个值与那个文件夹的名字保持一致，服务器就可以载入该存档。")]
        public string 世界名字
        {
            get { return level_name; }
            set { level_name = 世界名字; }
        }
        [Category("服务器设置"), Description("设置服务端传送给客户端的数据量，也就是设置玩家各个方向上的区块数量 (是以玩家为中心的半径，不是直径)。 它决定了服务端的可视距离。")]
        public int 视距
        {
            get { return view_distance; }
            set { view_distance = 视距; }
        }
        [Category("服务器设置"), Description("可选选项，可输入指向一个资源包的URI。玩家可选择是否使用该资源包。")]
        public string 资源包
        {
            get { return resource_pack; }
            set { resource_pack = 资源包; }
        }
        [Category("生成器设置"), Description("决定动物是否可以生成。")]
        public bool 是否生成动物
        {
            get { return spawn_animals; }
            set { spawn_animals = 是否生成动物; }
        }
        [Category("服务器设置"), Description("服务器的白名单，当启用时，只有白名单上的用户才能连接服务器。白名单主要用于私人服务器，例如相识的朋友等。")]
        public bool 是否开启白名单
        {
            get { return white_list; }
            set { white_list = 是否开启白名单; }
        }
        [Category("rcon设置"), Description("rcon密码")]
        public string rcon密码
        {
            get { return rcon_password; }
            set { rcon_password = rcon密码; }
        }
        [Category("生成器设置"), Description("定义是否在生成世界时生成结构（例如村庄）")]
        public bool 是否生成结构
        {
            get { return generate_structures; }
            set { generate_structures = 是否生成结构; }
        }
        [Category("服务器设置"), Description("是否开启在线验证。服务器会与 Minecraft 的账户数据库对比检查连入玩家。如果你的服务器并未与 Internet 连接，则将这个值设为 false ，然而这样的话破坏者也能够使用任意假账户登录服务器。如果 Minecraft.net 服务器下线，那么开启在线验证的服务器会因为无法验证玩家身份而拒绝所有玩家加入。通常，这个值设为 true 的服务器被称为“正版服务器”，设为 false 的被称为“离线服务器”或“盗版服务器”。")]
        public bool 是否启用正版验证
        {
            get { return online_mode; }
            set { online_mode = 是否启用正版验证; }
        }
        [Category("生成器设置"), Description("玩家在游戏中能够建造的最大高度。地形生成算法并不会受这个值的影响。")]
        public int 最大建筑高度
        {
            get { return max_build_height; }
            set { max_build_height = 最大建筑高度; }
        }
        [Category("生成器设置"), Description("与单人游戏类似，为你的世界定义一个种子。")]
        public string 地图种子
        {
            get { return level_seed; }
            set { level_seed = 地图种子; }
        }
        [Category("服务器设置"), Description("是否使用针对Linux平台的数据包收发优化，此选项仅会在Linux平台下生成。")]
        public bool 是否使用本地传送
        {
            get { return use_native_transport; }
            set { use_native_transport = 是否使用本地传送; }
        }
        [Category("服务器设置"), Description("如果服务器发送的和Mojang的验证服务器的ISP/AS不一样,玩家将会被踢出")]
        public bool 是否保护链接端口
        {
            get { return prevent_proxy_connections; }
            set { prevent_proxy_connections = 是否保护链接端口; }
        }
        [Category("服务器设置"), Description("本属性值是玩家客户端的多人游戏服务器列表中显示的服务器信息，显示于名称下方。")]
        public string motd内容
        {
            get { return motd; }
            set { motd = motd内容; }
        }
        [Category("rcon设置"), Description("是否允许远程访问服务器控制台。")]
        public bool 是否启用rcon
        {
            get { return enable_rcon; }
            set { enable_rcon = 是否启用rcon; }
        }
    }
}