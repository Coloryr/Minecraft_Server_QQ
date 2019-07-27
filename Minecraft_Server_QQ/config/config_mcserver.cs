using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Minecraft_Server_QQ
{
    //用来操作MC配置文件(server.properties)，不区分大小写
    public class config_mcserver
    {
        private string filePath;//文件路径
        private List<string> aTemp;//文件数据临时存储
        //初始化文件
        public bool Init(string filePath)
        {
            this.filePath = filePath;
            FileStream file;
            try
            {
                file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] tmpArr = new byte[file.Length];
                file.Read(tmpArr, 0, (int)file.Length);
                file.Close();
                aTemp = Encoding.Default.GetString(tmpArr).Split("\r\n".ToCharArray()).ToList();
                while(aTemp.Contains("") == true)
                    aTemp.Remove("");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string string_get(string a, string b)
        {
            int c = a.IndexOf(b);
            if (c > 0)
                return a.Substring(0, c);
            else
                return null;
        }
        //根据名称读取内容，如 pvp=true，传入pvp返回true,找不到返回空文本
        public string GetString(string s)
        {
            if (filePath == null || aTemp == null)
                return "";
            foreach (string szTmp in aTemp)
            {
                if (s == string_get(szTmp, "="))
                {
                    return szTmp.Substring(s.Length + 1, szTmp.Length - s.Length - 1);
                }        
            }
            return "";
        }
        //根据名称写入内容，没有则增加
        public bool SetString(string s, string val)
        {
            if (filePath == null || aTemp == null)
                return false;
            for (int i = 0; i < aTemp.Count; i++)
            {
                if (aTemp[i].Length > s.Length)
                {
                    if (aTemp[i].StartsWith(s, StringComparison.OrdinalIgnoreCase))
                    {
                        aTemp[i] = s + "=" + val;
                        return true;//已修改
                    }
                }
            }
            //未找到，则增加
            aTemp.Add(s + "=" + val);
            return true;
        }
        //关闭文件,参数决定是否将修改保存到文件
        public bool UnInit(bool IsSave)
        {
            if (filePath == null || aTemp == null)
                return false;
            if (IsSave)
            {
                string szSave = "";
                //存储到文件
                foreach (string s in aTemp)
                {
                    if (s != "")
                        szSave = szSave + s + "\r\n";
                }
                szSave = szSave.Substring(0, szSave.Length - 2);
                try
                {
                    byte[] tmpArr;
                    tmpArr = Encoding.Default.GetBytes(szSave);
                    FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    file.SetLength(0);
                    file.Write(tmpArr, 0, tmpArr.Length);
                    file.Close();
                }
                catch { return false; }
            }
            filePath = null;
            aTemp = null;
            return true;
        }
    }
}
