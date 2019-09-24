using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBackgroundChanger
{
    public partial class ChoseConfigForm : Form
    {
        public ChoseConfigForm()
        {
            InitializeComponent();
        }

        private void ChoseConfigButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void CreateConfigButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();
            config.Add("link", "https://www.reddit.com/r/wallpapers.json");
            MainForm.Config = config;
            saveFileDialog1.ShowDialog();
            
            ConfigurationManager.SaveConfig(config, saveFileDialog1.OpenFile() );
            saveFileDialog1.Dispose();
            Close();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MainForm.Config = ConfigurationManager.GetConfig(openFileDialog1.OpenFile());
            openFileDialog1.Dispose();
            Close();
        }
    }
}
