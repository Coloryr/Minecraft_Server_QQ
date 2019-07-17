using System;
using System.Threading;
using System.IO;

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
        private string Dir;
        private MCServer Server;
        public event pTask ptask;
        public MCSTask(MCServer server, string Dir)
        {
            this.Server = server;//用于后续计划任务实现
            this.Dir = Dir;
            this.taskDir = Dir + @"\Task\";
        }
        //初始化任务(把所有任务剩余计时改成循环周期时间)
        public void InitTask()
        {
            if (Directory.Exists(taskDir))
            {
                string [] files = Directory.GetFiles(taskDir,"*.ini");
                foreach (string s in files)
                {
                    //对于错误的配置文件则讲剩余时间修改为-1（永不执行）
                    WinAPI.WritePrivateProfileString(s,"ENCP TASK","S",WinAPI.GetPrivateProfileString(s,"ENCP TASK","time","-1"));
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
        private void Th_AutoMessage() 
        {
            Server.SendMessage("say [提醒]服务器还有1分钟将自动重启...");
            Thread.Sleep(50000);
            Server.SendMessage("say [提醒]服务器将于10秒后自动重启");
        }//用于发送自动重启提示
        private void Th_Task()
        {
            while (true)
            {
                Thread.Sleep(60000);
                //读取任务配置文件中的内容，判断并执行
                if (Directory.Exists(taskDir))
                {
                    string[] files = Directory.GetFiles(taskDir, "*.ini");
                    foreach (string s in files)
                    {
                        //首先将剩余时间S递减1,如果递减后为0则继续判断执行任务
                        string szTmp = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "S", "-1");
                        string content = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "content", "-1");
                        string type = WinAPI.GetPrivateProfileString(s, "ENCP TASK", "type", "-1");
                        int time;
                        try { time = int.Parse(szTmp); }
                        catch { time = -1; }
                        time--;
                        //如果任务是重启且剩余时间分别是10分钟，1分钟的时候则自动发送提示
                        if (content == "2" && type == "0")
                        {
                            if (time == 10)
                                Server.SendMessage("say [提醒]服务器还有10分钟将自动重启...");
                            if (time == 1)
                                new Thread(Th_AutoMessage).Start();
                        }
                        if (time <= 0)//执行任务
                        {
                            //将time改成任务周期时常
                            try { time = int.Parse(WinAPI.GetPrivateProfileString(s, "ENCP TASK", "time", "-1")); }
                            catch { time = -1; }
                            //首先判断任务类型
                            if (type == "0")
                            {
                                //系统内置任务，则根据content判断任务类型并执行对应功能
                                if (content == "0")
                                {//关闭服务器
                                    if (!Server.IsProcessRun())
                                        continue;
                                    if (ptask != null)
                                        ptask(0);
                                }
                                if (content == "1")
                                {//开启服务器
                                    if (Server.IsProcessRun())
                                        continue;
                                    if (ptask != null)
                                        ptask(1);
                                }
                                if (content == "2")
                                {//重启服务器
                                    if (ptask != null)
                                        ptask(2);
                                }
                                if (content == "3")
                                {//备份地图
                                    if (!Directory.Exists(Dir + @"\server\world\"))
                                        continue;//如果地图文件不存在就不需要向下执行备份工作了
                                    if (!Directory.Exists(Dir + @"\Backups\"))
                                        Directory.CreateDirectory(Dir+@"\Backups\");
                                    //按照时间创建文件夹
                                    string timeDir = DateTime.Now.ToString("yyyyMMdd-HH.mm.ss");
                                    Directory.CreateDirectory(Dir+@"\Backups\"+timeDir+"\\");
                                    //检测world,world_nether,world_the_end三个目录是否存在，存在则复制
                                    if (Directory.Exists(Dir + @"\server\world\"))
                                        other.CopyDirectory(Dir + @"\server\world", Dir + @"\Backups\" + timeDir + @"\world");
                                    if (Directory.Exists(Dir + @"\server\world_nether\"))
                                        other.CopyDirectory(Dir + @"\server\world_nether", Dir + @"\Backups\" + timeDir + @"\world_nether");
                                    if (Directory.Exists(Dir + @"\server\world_the_end\"))
                                        other.CopyDirectory(Dir + @"\server\world_the_end", Dir + @"\Backups\" + timeDir + @"\world_the_end");
                                }
                            }
                            if (type == "1")
                            {
                                //自定义任务，直接把内容发送给服务端即可
                                Server.SendMessage(WinAPI.GetPrivateProfileString(s, "ENCP TASK", "content",""));
                            }
                            //其他类型则无视
                        }
                        //将时间写回文件
                        WinAPI.WritePrivateProfileString(s, "ENCP TASK", "S", time.ToString());
                    }
                }
            }
        }
    }
}
