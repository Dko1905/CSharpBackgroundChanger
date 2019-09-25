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
    public partial class EditConfigForm : Form
    {
        public EditConfigForm()
        {
            InitializeComponent();
            LinkTextBox.Text = MainForm.Config["link"];
            changeTimeout.Value = Convert.ToDecimal(MainForm.Config["changeTimeout"]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MainForm.Config["link"] = LinkTextBox.Text;
            MainForm.Config["changeTimeout"] = changeTimeout.Value.ToString();
            saveFileDialog1.ShowDialog();

            ConfigurationManager.SaveConfig(MainForm.Config, saveFileDialog1.OpenFile());
        }
    }
}
