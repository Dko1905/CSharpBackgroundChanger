namespace DesktopBackgroundChanger
{
    partial class ChoseConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoseConfigButton = new System.Windows.Forms.Button();
            this.CreateConfigButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ChoseConfigButton
            // 
            this.ChoseConfigButton.Location = new System.Drawing.Point(13, 13);
            this.ChoseConfigButton.Name = "ChoseConfigButton";
            this.ChoseConfigButton.Size = new System.Drawing.Size(88, 23);
            this.ChoseConfigButton.TabIndex = 0;
            this.ChoseConfigButton.Text = "Chose Config";
            this.ChoseConfigButton.UseVisualStyleBackColor = true;
            this.ChoseConfigButton.Click += new System.EventHandler(this.ChoseConfigButton_Click);
            // 
            // CreateConfigButton
            // 
            this.CreateConfigButton.Location = new System.Drawing.Point(13, 43);
            this.CreateConfigButton.Name = "CreateConfigButton";
            this.CreateConfigButton.Size = new System.Drawing.Size(88, 23);
            this.CreateConfigButton.TabIndex = 1;
            this.CreateConfigButton.Text = "Create New";
            this.CreateConfigButton.UseVisualStyleBackColor = true;
            this.CreateConfigButton.Click += new System.EventHandler(this.CreateConfigButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config.json";
            this.openFileDialog1.Filter = "Json files| *.json; *.JSON";
            this.openFileDialog1.Title = "Chose Config";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "config.json";
            this.saveFileDialog1.Filter = "Json files| *.json; *.JSON";
            // 
            // ChoseConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 90);
            this.Controls.Add(this.CreateConfigButton);
            this.Controls.Add(this.ChoseConfigButton);
            this.Name = "ChoseConfigForm";
            this.Text = "ChoseConfigForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChoseConfigButton;
        private System.Windows.Forms.Button CreateConfigButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}