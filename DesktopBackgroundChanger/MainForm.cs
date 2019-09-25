using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBackgroundChanger
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, string> Config = null;
        private static bool _run;
        public MainForm()
        {
            InitializeComponent();
            if(Config == null)
            {
                using(ChoseConfigForm f = new ChoseConfigForm())
                {
                    f.ShowDialog(); // Focus on this form
                }
            }
        }

        private void changeBetween()
        {
            DirectoryInfo di = new DirectoryInfo(@".\cache\");
            FileInfo[] files = di.GetFiles();
            _run = true;
            int fileIndex = 0;
            while (_run)
            {
                if (fileIndex >= files.Length - 1)
                    fileIndex = 0;
                else
                    fileIndex++;
                FileInfo file = files[fileIndex];
                DesktopChanger.SetDesktopWallpaper(file.FullName);
                System.Threading.Thread.Sleep(Convert.ToInt32(Config["changeTimeout"]));
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "Started!";
            Task.Run(changeBetween);
        }

        private void ChangeConfigButton_Click(object sender, EventArgs e)
        {
            using(EditConfigForm f = new EditConfigForm())
            {
                f.ShowDialog();
            } 
        }

        public void setStatus(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(setStatus), new object[] { text });
                return;
            }
            StatusBox.Text = text;
        }

        private void doThing()
        {
            ImgGetter.saveImgsToCache();
            setStatus("Finished!");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "Started!";
            Task.Run(doThing);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _run = false;
            StatusBox.Text = "Stopped!";
        }
    }
}
