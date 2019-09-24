using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBackgroundChanger
{
    class ImgGetter
    {
        public static string getImgList() // Get json from reddit and sort them and give an array with only the picture links.
        {
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage msg = client.PostAsync("www.reddit.com/r/wallpapers/top.json", null).Result;
            }
            //https://www.reddit.com/r/wallpapers/top.json
            return "";
        }

        public void getImage()
        {

        }
    }
}
