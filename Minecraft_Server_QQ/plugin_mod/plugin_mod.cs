using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;

namespace Minecraft_Server_QQ
{
    class plugins_mod
    {
        public plugin_mod_list ReadPluginsInfo(string path)
        {
            if (!Directory.Exists(path + @"\plugins\"))
            {
                MessageBox.Show("未找到插件文件夹");
                return null;
            }
            string[] files = Directory.GetFiles(path + @"plugins\", "*.jar");
            plugin_mod_list list = new plugin_mod_list();
            foreach (string s in files)
            {
                plugin_mod_save save = new plugin_mod_save();
                if (GetPluginsInfo(s, out save) == false)
                {
                    MessageBox.Show("读取错误");
                    return null;
                }
                if(list.list.Contains(save) == false)
                    list.list.Add(save);
            }
            return list;
        }
        //读取插件(jar)信息,返回数组长度为4，内容分别是：插件名，版本，作者，本地文件名
        public bool GetPluginsInfo(string fileName, out plugin_mod_save save)
        {
            save = new plugin_mod_save();
            try
            {
                ZipFile zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("plugin.yml");
                if (zp == null)
                    return false;
                Stream stream = zip.GetInputStream(zp);
                TextReader reader = new StreamReader(stream);
                zip.Close();
                stream.Close();
                YamlStream yaml = new YamlStream();
                yaml.Load(reader);
                YamlMappingNode mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

                foreach (var entry in mapping.Children)
                {
                    if (entry.Key.ToString() == "name")
                        save.name = entry.Value.ToString();
                    if (entry.Key.ToString() == "version")
                        save.version = entry.Value.ToString();
                    if (entry.Key.ToString() == "author")
                        save.auth = entry.Value.ToString();
                }
                save.file = zip.Name;
                return true;
            }
            catch (Exception e)
            {
                logs.Log_write("[ERROR]" + e.Message);
                return false;
            }
        }
        //读取MOD(jar or zip)信息,返回数组长度为3，内容分别是：Mod名，版本，作者，文件名
        public bool GetModsInfo(string fileName, out string[] Arr)
        {
            Arr = new string[4];
            /*
            try
            {
                ZipFile zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("plugin.yml");
                if (zp == null)
                    return false;
                Stream stream = zip.GetInputStream(zp);
                TextReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                zip.Close();
                stream.Close();
                // Load the stream
                JObject json = JObject.Parse(text);
                if (json.ContainsKey("modList"))
                {
                    string a = json["modList"].First.ToString();
                    JObject modinfo = JObject.Parse(a);
                    Arr[0] = a["name"];
                    Arr[1] = a["version"];
                    Arr[2] = a["authorList"];
                    Arr[3] = zip.Name;
                }
                Arr[2] = zip.Name;
                return true;
            }
            catch (Exception e)
            {
                logs.Log_write("[ERROR]" + e.Message);
                return false;
            }
            */
            return false;
        }
    }
}
