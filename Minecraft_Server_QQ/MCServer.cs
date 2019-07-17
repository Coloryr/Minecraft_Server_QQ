using System.Diagnostics;
using System.Threading;

namespace Minecraft_Server_QQ
{
    //这个类负责包括调用java运行服务端，获取回显文本，发送指令到服务端等工作
    class MCServer
    {
        public delegate void serverEventHandler(object sender, Event.MCSEvent e);
        public event serverEventHandler serverMessage;//回显文本事件
        public event serverEventHandler serverStop;//服务器关闭通知
        public event serverEventHandler serverRestart;//服务器重启事件
        private string fileDir;//决定服务端运行在那个目录
        private string javaPath;//java.exe路径
        private Process ps;//进程
        private Thread th_output;//监控OutPut输出线程
        private Thread th_errorput;//监控ErrorPut输出线程
        private Thread th_ps;//监控进程运行状态线程
        private Thread th_jishi;//计时线程，用于解决部分电脑出现的兼容性BUG
        private Thread th_restart;//重启用监控线程
        private int nTime;//已经过时间，用于计时线程
        private bool serverIsRun;//服务端是否在运行
        private string serverVer;//服务端版本
        private string cmd;//命令行，保存重启用
        public MCServer(string fileDir)
        {
            this.fileDir = fileDir;
        }
        public bool Run(string javaPath,string cmd)
        {
            if (this.IsProcessRun())
                return false;
            ps = new Process();
            ps.StartInfo.FileName = javaPath;
            ps.StartInfo.Arguments = cmd;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.RedirectStandardError = true;
            ps.StartInfo.RedirectStandardInput = true;
            ps.StartInfo.RedirectStandardOutput = true;
            ps.StartInfo.WorkingDirectory = fileDir;
            ps.StartInfo.CreateNoWindow = true;
            try 
            { 
                ps.Start(); 
            }
            catch 
            {
                ps = null;
                return false; 
            }
            //进程启动成功，则创建监控线程
            th_output = new Thread(Th_OutPut);
            th_errorput = new Thread(Th_ErrorPut);
            th_jishi = new Thread(Th_Jishi);
            th_ps = new Thread(Th_Ps);
            try
            {
                th_output.Start();
                th_errorput.Start();
                th_jishi.Start();
                th_ps.Start();
            }catch{
                ps.Kill();
                return false;
            }
            nTime = 0;
            this.cmd = cmd;
            this.javaPath = javaPath;
            return true;
        }//根据命令行启动进程

        //四条监控相关线程
        private void Th_OutPut()
        {
            try
            {//不排除特殊情况下ps对象先被清理但是线程尚未退出，所以要接管异常
                string line;
                while ((line = ps.StandardOutput.ReadLine()) != null)
                {
                    line = line.Replace("\b", "");//删除退格键，部分MCPC服务端会因为退格键不处理出现乱码
                    if (!serverIsRun)
                    {
                        nTime = 0;
                        int a = line.IndexOf("Starting minecraft server");
                        if (a != -1)
                        {
                            a = a + 33;
                            serverVer = line.Substring(a).Trim();
                        }
                        if (line.IndexOf("Done") != -1)
                        {
                            line = "[提醒] 服务端已成功运行，您可以进入服务器了。";
                            serverIsRun = true;
                        }
                    }
                    if (serverMessage != null)
                        serverMessage(this, new Event.MCSEvent(line, 0));
                }
            }
            catch { }
        }
        private void Th_ErrorPut()
        {
            string line;
            try
            {
                while ((line = ps.StandardError.ReadLine()) != null)
                {
                    line = line.Replace("\b","");//删除退格键，部分MCPC服务端会因为退格键不处理出现乱码
                    nTime = 0;
                    if (!serverIsRun)
                    {
                        int a = line.IndexOf("Starting minecraft server");
                        if (a != -1)
                        {
                            a = a + 33;
                            serverVer = line.Substring(a).Trim();
                        }
                        if (line.IndexOf("Done") != -1)
                        {
                            line = "[提醒] 服务端已成功运行，您可以进入服务器了。";
                            serverIsRun = true;
                        }
                    }
                    if (serverMessage != null)
                        serverMessage(this, new Event.MCSEvent(line, 0));
                }
            }
            catch { }
        }
        private void Th_Ps()
        {
            ps.WaitForExit();
            if (serverStop != null)
                serverStop(this,new Event.MCSEvent(null,ps.ExitCode));
            //清理对象
            ps = null;
            try
            {
                th_output.Abort();
                th_errorput.Abort();
                th_jishi.Abort();
            }
            catch { }
            serverVer = null;
            serverIsRun = false;
        }
        private void Th_Jishi()
        {
            while (!this.IsRun())//只有进程启动但服务端尚未运行的时候需要计时
            {
                nTime = nTime + 1;
                Thread.Sleep(1000);
                if (nTime >= 15)
                {
                    SendMessage("ping");//如果卡顿则给服务端发送指令即可，原因未知....
                    nTime = 0;
                }
            }
        }
        private void Th_Restart()
        {
            //首先屏蔽事件。重启不需要事件。
            serverEventHandler tmp = this.serverStop;
            this.serverStop = null;
            Stop();
            if (!ps.WaitForExit(300000)) 
            {
                ps.Kill();//等了5分钟还没能关闭，则强制退出。不过可能造成回档问题
            }
            Thread.Sleep(2000);
            if (!Run(this.javaPath,this.cmd))
            {
                if (serverMessage != null)
                    serverMessage(this, new Event.MCSEvent("[警告]重启服务器失败！", 0));
                if (tmp != null)
                    tmp(this,new Event.MCSEvent(null,-1));
            }
            this.serverStop = tmp;
            if (this.serverRestart != null)
                this.serverRestart(this,new Event.MCSEvent(null,0));
        }

        public bool Stop()
        {
            if (!serverIsRun)
                return false;
            SendMessage("stop");
            return true;
        }//发送stop指令来终止服务端
        public bool Close()
        {
            if (IsProcessRun())
            {
                ps.Kill();
                return true;
            }
            return false;
        }//强制关闭进程
        public bool Restart()
        {
            if (!serverIsRun)
                return false;
            //为了保证不卡，重启采用线程执行，重启完毕后将通过事件通知
            th_restart = new Thread(Th_Restart);
            try
            {
                th_restart.Start();
            }catch {
                return false;
            }
            return true;
        }//重启服务端(不触发服务器关闭事件)
        public string GetServerVer()
        {
            return serverVer;
        }//获取服务端版本文本
        public bool IsRun()
        {
            return serverIsRun;
        }//返回服务端是否在运行(非进程)
        public bool IsProcessRun()
        {
            if (ps == null)
                return false;
            return true;
        }//返回进程是否在运行
        public bool SendMessage(string cmd)
        {
            if (!IsProcessRun())
                return false;
            ps.StandardInput.WriteLine(cmd);
            return true;
        }//发送命令行给服务端
    }
}

