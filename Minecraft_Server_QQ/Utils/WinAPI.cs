using System;
using System.Text;
using System.Runtime.InteropServices;

//本文件是对WinAPI实现的功能的再封装，以便软件使用
namespace Minecraft_Server_QQ.Utils
{
    static class WinAPI
    {
        public struct MEMORYSTATUS1 //这个结构用于获得系统信息        
        {
            internal int dwLength;
            internal int dwMemoryLoad;
            internal long ullTotalPhys;
            internal long ullAvailPhys;
            internal long ullTotalPageFile;
            internal long ullAvailPageFile;
            internal long ullTotalVirtual;
            internal long ullAvailVirtual;
            internal long ullAvailExtendedVirtual;
        }
        [DllImport("kernel32.dll ")]      
        public static extern void GlobalMemoryStatusEx(ref MEMORYSTATUS1 lpBuffer); 
    }
}
