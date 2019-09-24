namespace DesktopBackgroundChanger
{
    partial class StartupConfigure
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChoseConfigButton = new System.Windows.Forms.Button();
            this.CreateConfigButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chose a config or create new config.";
            // 
            // ChoseConfigButton
            // 
            this.ChoseConfigButton.Location = new System.Drawing.Point(15, 25);
            this.ChoseConfigButton.Name = "ChoseConfigButton";
            this.ChoseConfigButton.Size = new System.Drawing.Size(120, 23);
            this.ChoseConfigButton.TabIndex = 1;
            this.ChoseConfigButton.Text = "Chose config.";
            this.ChoseConfigButton.UseVisualStyleBackColor = true;
            this.ChoseConfigButton.Click += new System.EventHandler(this.ChoseConfigButton_Click);
            // 
            // CreateConfigButton
            // 
            this.CreateConfigButton.Location = new System.Drawing.Point(15, 55);
            this.CreateConfigButton.Name = "CreateConfigButton";
            this.CreateConfigButton.Size = new System.Drawing.Size(120, 23);
            this.CreateConfigButton.TabIndex = 2;
            this.CreateConfigButton.Text = "Create new config";
            this.CreateConfigButton.UseVisualStyleBackColor = true;
            this.CreateConfigButton.Click += new System.EventHandler(this.CreateConfigButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config.json";
            this.openFileDialog1.Filter = "Json Files| *.json; *.JSON";
            this.openFileDialog1.Title = "Chose Config";
            // 
            // StartupConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 202);
            this.Controls.Add(this.CreateConfigButton);
            this.Controls.Add(this.ChoseConfigButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StartupConfigure";
            this.Text = "Chose Config File.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChoseConfigButton;
        private System.Windows.Forms.Button CreateConfigButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

