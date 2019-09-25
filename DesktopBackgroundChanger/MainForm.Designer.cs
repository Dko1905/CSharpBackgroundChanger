namespace DesktopBackgroundChanger
{
    partial class MainForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ChangeConfigButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Green;
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChangeConfigButton
            // 
            this.ChangeConfigButton.Location = new System.Drawing.Point(94, 13);
            this.ChangeConfigButton.Name = "ChangeConfigButton";
            this.ChangeConfigButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeConfigButton.TabIndex = 1;
            this.ChangeConfigButton.Text = "Edit Config";
            this.ChangeConfigButton.UseVisualStyleBackColor = true;
            this.ChangeConfigButton.Click += new System.EventHandler(this.ChangeConfigButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(306, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(13, 43);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Enabled = false;
            this.StatusBox.Location = new System.Drawing.Point(306, 161);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(75, 20);
            this.StatusBox.TabIndex = 4;
            this.StatusBox.Text = "Nothing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 193);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ChangeConfigButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "Desktop Background Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ChangeConfigButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox StatusBox;
    }
}

