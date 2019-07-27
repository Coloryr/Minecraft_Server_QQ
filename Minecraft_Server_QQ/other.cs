using System;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using YamlDotNet.RepresentationModel;

namespace Minecraft_Server_QQ
{
    //这个类存放一些杂七杂八的需要的小功能合集
    class other
    {
        //检测某端口是否可用，如果被占用返回false,可用返回true
        static public bool PortInUse(int port)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                    return false;
            }
            return true;
        }
        //搜索java.exe，如果找到返回路径，找不到返回空文本
        static public string SeachJava()
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                if (item.DriveType == DriveType.Fixed)
                {
                    string s;
                    s = FindFile("java.exe", item.ToString() + "Program Files\\Java");
                    if (s.Length != 0)
                        return s;
                    s = FindFile("java.exe", item.ToString() + "Program Files (x86)\\Java");
                    if (s.Length != 0)
                        return s;
                }
            }
            return "";
        }
        static private string FindFile(String filename, String path)
        {
            if (Directory.Exists(path))
            {
                if (File.Exists(path + "\\" + filename))
                    return path + "\\" + filename;
                String[] directorys = Directory.GetDirectories(path);
                foreach (String d in directorys)
                {
                    String p = FindFile(filename, d);
                    if (p.Length != 0)
                        return p;
                }
            }
            return "";
        }
        static public void CopyDirectory(string Dir, string mubiaoDir)//拷贝目录，目录均无\结尾
        {
            try
            {
                if (System.IO.Directory.Exists(Dir) == false)
                    return;
                //目录均无\结尾
                System.IO.Directory.CreateDirectory(mubiaoDir);
                string[] Arr;
                Arr = System.IO.Directory.GetFiles(Dir);
                foreach (string s in Arr)
                {
                    System.IO.File.Copy(s, mubiaoDir + @"\" + GetPathFileName(s), true);
                }
                Arr = System.IO.Directory.GetDirectories(Dir);
                foreach (string s in Arr)
                {
                    CopyDirectory(s, mubiaoDir + "\\" + GetPathFileName(s));
                }
            }
            catch { }
        }
        static public string GetPathFileName(string Path)//获取路径中的文件名
        {
            //获取路径末尾的文件名
            int i = Path.LastIndexOf(@"\");
            if (i == -1)
                return Path;
            i = i + 1;
            return Path.Substring(i, Path.Length - i);

        }

        //调用系统默认浏览器打开URL链接，如果失败则复制URL到剪辑版
        static public bool OpenURL(string url)
        {
            try
            {
                Process.Start(url);
                return true;
            }
            catch
            {
                Clipboard.SetDataObject(url);
                return false;
            }
        }
    }
}
