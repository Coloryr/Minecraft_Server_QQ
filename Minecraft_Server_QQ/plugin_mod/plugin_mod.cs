using ICSharpCode.SharpZipLib.Zip;
using Minecraft_Server_QQ.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
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
                plugin_mod_save save = GetPluginsInfo(path, file);
                if (list.list.Contains(save) == false)
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
                plugin_mod_save save = GetModsInfo(path, file);
                if (list.list.Contains(save) == false)
                    list.list.Add(save);
            }
            return list;
        }
        //读取插件(jar)信息,返回数组长度为4，内容分别是：插件名，版本，作者，本地文件名
        public plugin_mod_save GetPluginsInfo(string path, string fileName)
        {
            plugin_mod_save save = new plugin_mod_save();
            ZipFile zip = null;
            Stream stream = null;
            try
            {
                zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("plugin.yml");
                if (zp == null)
                {
                    save.file = save.name = fileName.Replace(path + @"plugins\", "");
                    return save;
                }
                stream = zip.GetInputStream(zp);
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
                return save;
            }
            catch (Exception e)
            {
                save.file = save.name = fileName.Replace(path + @"plugins\", "");
                logs.Log_write("[ERROR]" + e.Message);
                if (zip != null)
                    zip.Close();
                if (stream != null)
                    stream.Close();
                return save;
            }
        }
        public plugin_mod_save GetModsInfo(string path, string fileName)
        {
            plugin_mod_save save = new plugin_mod_save();
            ZipFile zip = null;
            Stream stream = null;
            try
            {
                zip = new ZipFile(fileName);
                ZipEntry zp = zip.GetEntry("mcmod.info");
                if (zp == null)
                {
                    save.file = save.name = fileName.Replace(path + @"mods\", "");
                    return save;
                }
                stream = zip.GetInputStream(zp);
                TextReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                JObject json = JObject.Parse(text);
                if (json.ContainsKey("modList"))
                {
                    string a = json["modList"].First.ToString();
                    JObject modinfo = JObject.Parse(a);
                    save.name = modinfo["name"].ToString();
                    save.version = modinfo["version"].ToString();
                    save.auth = modinfo["authorList"].ToString();
                    save.file = zip.Name;
                }
                zip.Close();
                stream.Close();
                return save;
            }
            catch (Exception e)
            {
                logs.Log_write("[ERROR]" + e.Message);
                if (zip != null)
                    zip.Close();
                if (stream != null)
                    stream.Close();
                return save;
            }
        }
    }
}
