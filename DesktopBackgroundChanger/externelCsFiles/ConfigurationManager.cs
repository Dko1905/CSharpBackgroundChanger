using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesktopBackgroundChanger
{
    static class ConfigurationManager
    {
        public static Dictionary<string, string> GetDefaultConfig()
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            conf.Add("link", "https://www.reddit.com/r/wallpapers.json");
            conf.Add("changeTimeout", "1000");
            return conf;
        } 
        public static Dictionary<string, string> GetConfig(string path)
        {
            string jsonString = File.ReadAllText(path, Encoding.UTF8);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }
        public static void SaveConfig(Dictionary<string, string> config, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(config) );
        }
        public static Dictionary<string, string> GetConfig(Stream fs)
        {
            string jsonString;
            using ( StreamReader sr = new StreamReader(fs))
            {
                jsonString = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }
        public static void SaveConfig(Dictionary<string, string> config, Stream fs)
        {
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(JsonConvert.SerializeObject(config));
            }
            fs.Close();
        }
    }
}
