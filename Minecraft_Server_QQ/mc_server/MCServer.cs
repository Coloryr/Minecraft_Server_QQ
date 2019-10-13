using Minecraft_Server_QQ.Config;
using Minecraft_Server_QQ.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    //这个类负责包括调用java运行服务端，获取回显文本，发送指令到服务端等工作
    class MCServer
    {
        public delegate void serverEventHandler(object sender, Event.MCSEvent e);

        public event serverEventHandler serverMessage;//回显文本事件
        public event serverEventHandler serverStop;   //服务器关闭通知
        public event serverEventHandler serverRestart;//服务器重启事件

        private Server_Save Config;                //服务器配置文件

        private Process ps = new Process();//进程

        public int server_now = 0;
        public MCServer(Server_Save Config)
        {
            this.Config = Config;
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
            info.WorkingDirectory = Config.server_local;
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
        public void Stop()
        {
            if (ps.HasExited)
            SendMessage("stop");
            SendMessage("end");
        }
        public bool Close()
        {
            if (IsProcessRun())
            {
                ps.Kill();
                return true;
            }
            return false;
        }
        public bool Restart()
        {
            if (server_now == 0)
                return false;
            Task.Factory.StartNew(() =>
            {
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
        }
        public int IsRun()
        {
            return server_now;
        }
        public bool SendMessage(string cmd)
        {
            if (!IsProcessRun())
                return false;
            ps.StandardInput.WriteLine(cmd);
            return true;
        }

        public bool IsProcessRun()
        {
            return ps.HasExited;
        }
        public void Start_Server()
        {
            if (!File.Exists(server_save.server_local + server_save.server_core))
            {
                MessageBox.Show("服务器核心未找到，请设置服务器核心");
                return;
            }
            string javaPath = server_save.java_local;
            if (string.IsNullOrWhiteSpace(javaPath) || !File.Exists(javaPath))
            {
                MessageBox.Show("JAVA错误，请重新设置");
                return;
            }

            Config_properties config = new Config_properties();

            if (server_save.max_m == 0 || server_save.min_m == 0)
            {
                MessageBox.Show("内存设置错误");
                return;
            }
            string cmd = string.Format("{0} -Xmx{1}M -Xms{2}M -Djline.terminal=jline.UnsupportedTerminal -jar \"{3}\" {4}",
                server_save.java_arg, server_save.max_m.ToString(), server_save.min_m.ToString(),
                server_save.server_local + server_save.server_core, server_save.server_arg);

            if (!server_save.Server.Run(javaPath, cmd))
            {
                MessageBox.Show("进程创建失败！");
                return;
            }

            logs.Log_write("启动服务器：" + cmd);

            button_serverRun.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRun, false });
            button_serverStop.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverStop, true });
            button_serverRest.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRest, true });
        }

        public void Stop_Server()
        {
            server_save.Server.Stop();
        }
    }
}

