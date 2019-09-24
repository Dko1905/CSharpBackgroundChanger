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
    public partial class Configure : Form
    {

        private Dictionary<string, string> _config;
        public Configure(Dictionary<string, string> config)
        {
            InitializeComponent();
            this._config = config;
            LinkBox.Text = _config["link"];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ConfigurationManager.SaveConfig(_config, saveFileDialog1.OpenFile());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
