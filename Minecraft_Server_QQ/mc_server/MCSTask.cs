using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using Minecraft_Server_QQ.Config;

namespace Minecraft_Server_QQ
{
    //计划任务实现部分
    class MCSTask
    {
        /*
         *计划任务文件格式说明
         *type=类型，0为内置类型，1为自定义任务
         *content=任务具体内容，当type=0,0=关闭服务器,1=开启服务器,2=重启服务器,3=备份地图
         *        当type=1时，直接发送content定义内容到服务器后台,如 say 自动喊话
         *time=任务重复周期，单位为分钟
         *S=剩余时间
         *T=剩余执行次数，旧版本属性，已废弃
         */
        public delegate void pTask(int s);
        private Thread thread;
        private string taskDir;
        private Server_Save Server;
        public event pTask ptask;
        public MCSTask(Server_Save server)
        {
            this.Server = server;//用于后续计划任务实现
        }
        //初始化任务(把所有任务剩余计时改成循环周期时间)
        public void InitTask()
        {
            if (Directory.Exists(taskDir))
            {
                string [] files = Directory.GetFiles(taskDir,"*.ini");
                foreach (string s in files)
                {

                }
            }
        }
        //创建线程开始执行计划任务（不重复创建）
        public void StartTask()
        {
            if (thread == null)
            {
                thread = new Thread(Th_Task);
                thread.Start();
            }
        }
        public int StopTask()
        {
            if (thread != null && thread.IsAlive == true)
                thread.Abort();
            return 0;
        }
        private void Th_AutoMessage() 
        {
            Server.SendMessage("say [提醒]服务器还有1分钟将自动重启...");
            Thread.Sleep(1000);
            Server.SendMessage("say [提醒]服务器将于10秒后自动重启");
        }//用于发送自动重启提示
        private void Th_Task()
        {

        }
    }
}
