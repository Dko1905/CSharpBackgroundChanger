﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DesktopBackgroundChanger
{
    class ImgGetter
    {


        public static async Task<IEnumerable<string>>  getImgList() // Get json from reddit and sort them and give a List with only the picture links.
        {
            List<string> imgLinks = new List<string>();
            JObject json;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage msg = client.GetAsync(MainForm.Config["link"]).Result;
                json = JObject.Parse(await msg.Content.ReadAsStringAsync() );
                
            }
            
            if(json.ContainsKey("error"))
            {
                throw new System.ArgumentException(json["error"].ToString() + " ERROR "+ json["message"].ToString());
            }
            var linqQuarry = from pictureData in json["data"]["children"]
                             let url = pictureData["data"]["url"].ToObject<string>()
                             where url.Contains(".png") ||
                                   url.Contains(".jpg") ||
                                   url.Contains(".jpeg")
                             select url;
            return linqQuarry;
        }

        public static async void saveImgsToCache()
        {
            IEnumerable<string> imgLinks = await getImgList();
            
            if (!Directory.Exists(@".\cache\"))
            {
                Directory.CreateDirectory(@".\cache\");
            }
            Parallel.ForEach(imgLinks, (string link) => {
                using (WebClient client = new WebClient())
                {
                    //Console.WriteLine(link);
                    client.DownloadFile(new Uri(link), @".\cache\" + link.Substring(link.Length - 11, 11));
                }
            });
        }
    }
}
