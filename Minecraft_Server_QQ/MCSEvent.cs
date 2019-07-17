using System;

namespace Minecraft_Server_QQ.Event
{
    class MCSEvent : EventArgs
    {
        public string cmd;//用来传递命令行
        public int exitCode;//进程退出码
        public MCSEvent(string cmd, int exitCode)
        {
            this.cmd = cmd;
            this.exitCode = exitCode;
        }
    }
}
