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
        public static Dictionary<string, string> GetConfig(string path)
        {
            string jsonString = File.ReadAllText(path, Encoding.UTF8);
            Dictionary<string, string> conf = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            jsonString = null; // no need to have memory to the string.
            return conf;
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
            
            Dictionary<string, string> conf = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            jsonString = null; // no need to have memory to the string.
            return conf;
        }
        public static void SaveConfig(Dictionary<string, string> config, Stream fs)
        {
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(JsonConvert.SerializeObject(config));
            }
        }
    }
}
