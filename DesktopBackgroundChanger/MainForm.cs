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
    public partial class MainForm : Form
    {
        public static Dictionary<string, string> Config = null;
        public MainForm()
        {
            InitializeComponent();
            if(Config == null)
            {
                ChoseConfigForm f = new ChoseConfigForm();
                f.ShowDialog(); // Focus on this form
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Config["link"]);
        }
    }
}
