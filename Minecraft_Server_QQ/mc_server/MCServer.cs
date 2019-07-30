using Minecraft_Server_QQ.Utils;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Minecraft_Server_QQ
{
    //这个类负责包括调用java运行服务端，获取回显文本，发送指令到服务端等工作
    class MCServer
    {
        public delegate void serverEventHandler(object sender, Event.MCSEvent e);
        public event serverEventHandler serverMessage;//回显文本事件
        public event serverEventHandler serverStop;   //服务器关闭通知
        public event serverEventHandler serverRestart;//服务器重启事件
        private string fileDir;//决定服务端运行在那个目录
        private string javaPath;//java.exe路径
        private Process ps;//进程
        private string cmd;//命令行，保存重启用
        public int server_now = 0;
        public MCServer(string fileDir)
        {
            this.fileDir = fileDir;
        }
        public bool Run(string javaPath, string cmd)
        {
            if (IsProcessRun())
                return false;
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = javaPath;
            info.Arguments = cmd;
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.WorkingDirectory = fileDir;
            info.CreateNoWindow = true;
            try
            {
                ps = Process.Start(info);
                server_now = 1;
            }
            catch(Exception e)
            {
                ps = null;
                logs.Log_write("[ERROR]" + e.Message);
                return false;
            }
            //进程启动成功，则创建监控线程
            Task_run();
            this.cmd = cmd;
            this.javaPath = javaPath;
            return true;
        }//根据命令行启动进程

        public void Task_run()
        {
            Task.Factory.StartNew(() =>
            {
                string line;
                while ((line = ps.StandardOutput.ReadLine()) != null)
                {
                    line = line.Replace("\b", "");//删除退格键，部分MCPC服务端会因为退格键不处理出现乱码
                    if (server_now == 1)
                    {
                        if (line.IndexOf("Done") != -1)
                        {
                            line = line + "\n[提醒] 服务端已成功运行，您可以进入服务器了。";
                            server_now = 2;
                        }
                    }
                    serverMessage?.Invoke(this, new Event.MCSEvent(line, 0));
                    Thread.Sleep(10);
                }
            });
            Task.Factory.StartNew(() =>
            {
                ps.WaitForExit();
                serverStop?.Invoke(this, new Event.MCSEvent(null, ps.ExitCode));
                //清理对象
                ps = null;
                server_now = 0;
                Thread.Sleep(10);
            });
        }
        public bool Stop()
        {
            if (server_now == 0)
                return false;
            SendMessage("stop");
            SendMessage("end");
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
            if (server_now == 0)
                return false;
            //为了保证不卡，重启采用线程执行，重启完毕后将通过事件通知
            Task.Factory.StartNew(() =>
            {
                //首先屏蔽事件。重启不需要事件。
                serverEventHandler tmp = this.serverStop;
                this.serverStop = null;
                Stop();
                while (ps.HasExited == false)
                {
                    Thread.Sleep(2000);
                }
                if (!Run(javaPath, cmd))
                {
                    tmp?.Invoke(this, new Event.MCSEvent(null, -1));
                }
                serverStop = tmp;
                serverRestart?.Invoke(this, new Event.MCSEvent(null, 0));
            });
            return true;
        }//重启服务端(不触发服务器关闭事件)
        public int IsRun()
        {
            return server_now;
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

