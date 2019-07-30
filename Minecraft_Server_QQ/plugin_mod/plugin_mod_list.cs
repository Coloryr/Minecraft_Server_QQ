using System.Collections.Generic;

namespace Minecraft_Server_QQ
{
    class plugin_mod_list
    {
        public List<plugin_mod_save> list = new List<plugin_mod_save> { };
    }
    class plugin_mod_save
    {
        public string name;
        public string version;
        public string auth;
        public string file;
    }
}
