using System;
using System.Text;
using System.Runtime.InteropServices;

//本文件是对WinAPI实现的功能的再封装，以便软件使用
namespace Minecraft_Server_QQ
{
    static class WinAPI
    {
        #region 具体功能需要使用的WinAPI的申明
        public struct MEMORYSTATUS1 //这个结构用于获得系统信息        
        {
            internal Int32 dwLength;
            internal Int32 dwMemoryLoad;
            internal Int64 ullTotalPhys;
            internal Int64 ullAvailPhys;
            internal Int64 ullTotalPageFile;
            internal Int64 ullAvailPageFile;
            internal Int64 ullTotalVirtual;
            internal Int64 ullAvailVirtual;
            internal Int64 ullAvailExtendedVirtual;
        }
        [DllImport("kernel32.dll ")]      
        static extern void GlobalMemoryStatusEx(ref MEMORYSTATUS1 lpBuffer); 
        [DllImport("kernel32",EntryPoint = "GetPrivateProfileString")]
        static extern int API_GetPrivateProfileString(string lpApplicationName,string lpKeyName,string lpDefault,StringBuilder lpReturnedString,int nSize,string lpFileName);
        [DllImport("kernel32",EntryPoint = "WritePrivateProfileString")]
        static extern bool API_WritePrivateProfileString(string lpApplicationName,string lpKeyName,string lpString,string lpFileName);

        #endregion
        //读取ini配置文件中的配置项，要求目标ini文件采用Unicode编码，如果遇到\\n会自动转换为\n
        static public string GetPrivateProfileString(string fileName,string applicationName,string keyName,string defaultName)
        {
            int nSize = 64;
            StringBuilder szTmp=new StringBuilder(nSize);
            while (true)
            {
                if (API_GetPrivateProfileString(applicationName, keyName, defaultName,szTmp, nSize, fileName) == nSize-1)
                {
                    nSize = nSize + 64;
                    szTmp = new StringBuilder(nSize);
                }else{
                    break;
                }
            }
            return szTmp.ToString().Replace("\\n","\n");//将配置文件中的\n转换为换行(如果有)
        }
        //写入ini配置文件中的配置项，将按照Unicode编码写入
        static public bool WritePrivateProfileString(string fileName,string applicationName,string keyName,string stringName)
        {
            return API_WritePrivateProfileString(applicationName,keyName,stringName,fileName);
        }
        //读取内存状态
        static public string ReadMemory()
        {
            //读取内存状态
            MEMORYSTATUS1 vBuffer = new MEMORYSTATUS1();//实例化结构  
            vBuffer.dwLength = 64;
            GlobalMemoryStatusEx(ref   vBuffer);//给此结构赋值搜索            
            string useinfo = Convert.ToString((vBuffer.ullTotalPhys - vBuffer.ullAvailPhys) / 1024 / 1024);//获得已用内存量            
            string allinfo = Convert.ToString(vBuffer.ullTotalPhys / 1024 / 1024);//获得内存总量
            return useinfo + "M/" + allinfo + "M";
        }
        //读取剩余内存（MB）
        static public int ReadFreeMemory()
        {
            MEMORYSTATUS1 vBuffer = new MEMORYSTATUS1();
            vBuffer.dwLength = 64;
            GlobalMemoryStatusEx(ref vBuffer);
            return (int)(vBuffer.ullAvailPhys / 1024 / 1024);
        }
    }
}
