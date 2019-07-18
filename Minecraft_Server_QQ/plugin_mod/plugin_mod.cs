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
                MessageBox.Show("未找到plugins文件夹");
                return null;
            }
            string[] files = Directory.GetFiles(path + @"plugins\", "*.jar");
            plugin_mod_list list = new plugin_mod_list();
            foreach (string file in files)
            {
                plugin_mod_save save = new plugin_mod_save();
                GetPluginsInfo(path, file, out save);
                if(list.list.Contains(save) == false)
                    list.list.Add(save);
            }
            return list;
        }
        public plugin_mod_list ReadModInfo(string path)
        {
            if (!Directory.Exists(path + @"\mods\"))
            {
                MessageBox.Show("未找到mods文件夹");
                return null;
            }
            string[] files = Directory.GetFiles(path + @"mods\", "*.jar");
            plugin_mod_list list = new plugin_mod_list();
            foreach (string file in files)
            {
                plugin_mod_save save = new plugin_mod_save();
                if (GetModsInfo(path, file, out save) == false)
                {
                    MessageBox.Show("读取错误");
                    return null;
                }
                if (list.list.Contains(save) == false)
                    list.list.Add(save);
            }
            return list;
        }
        //读取插件(jar)信息,返回数组长度为4，内容分别是：插件名，版本，作者，本地文件名
        public void GetPluginsInfo(string path, string fileName, out plugin_mod_save save)
        {
            save = new plugin_mod_save();
            try
            {
                ZipFile zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("plugin.yml");
                if (zp == null)
                {
                    save.file = save.name = fileName.Replace(path + @"plugins\", "");
                    return;
                }
                Stream stream = zip.GetInputStream(zp);
                TextReader reader = new StreamReader(stream);
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
                    if (entry.Key.ToString() == "authors")
                        save.auth = entry.Value.ToString();
                }
                save.file = fileName.Replace(path + @"plugins\", "");
                zip.Close();
                stream.Close();
                return;
            }
            catch (Exception e)
            {
                save.file = save.name = fileName.Replace(path + @"plugins\", "");
                logs.Log_write("[ERROR]" + e.Message);
                return;
            }
        }
        public bool GetModsInfo(string path, string fileName, out plugin_mod_save save)
        {
            save = new plugin_mod_save();
            /*
            try
            {
                ZipFile zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("mcmod.info");
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
                    save.name = a["name"];
                    save.version = a["version"];
                    save.auth = a["authorList"];
                    save.file = zip.Name;
                }
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
