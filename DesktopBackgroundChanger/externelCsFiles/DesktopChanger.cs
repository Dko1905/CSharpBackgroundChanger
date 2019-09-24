using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



public static class DesktopChanger
{

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SystemParametersInfo(
      int uAction,
      int uParam,
      string lpvParam,
      int fuWinIni);

    public static void SetDesktopWallpaper(string imgPath)
    {
        Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
        SystemParametersInfo(20, 0, imgPath, 3);
    }
}