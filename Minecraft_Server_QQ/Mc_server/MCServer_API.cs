namespace Minecraft_Server_QQ.Mc_server
{
    class MCServer_API
    {
        /// <summary>
        /// 服务器事件
        /// </summary>
        public delegate void serverEventHandler(object sender, Event.MCSEvent e);
        /// <summary>
        /// 服务器事件
        /// </summary>
        public delegate void opEventHandler(object sender, object var);
    }
}
