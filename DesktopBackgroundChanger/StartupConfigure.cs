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
    public partial class StartupConfigure : Form
    {
        public StartupConfigure()
        {
            InitializeComponent();
        }

        private void ChoseConfigButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MainScreen MSForm = new MainScreen(ConfigurationManager.GetConfig(openFileDialog1.OpenFile()));
            MSForm.Show();
        }

        private void CreateConfigButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> s = new Dictionary<string, string>();
            s.Add("link", "https://www.reddit.com/r/wallpapers.json"); // deafoult link
            Configure cForm = new Configure(s);
            cForm.Show();
        }
    }
}
