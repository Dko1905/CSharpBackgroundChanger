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
    public partial class MainScreen : Form
    {
        private Dictionary<string, string> _config;
        public MainScreen(Dictionary<string, string> config)
        {
            InitializeComponent();
            _config = config;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
