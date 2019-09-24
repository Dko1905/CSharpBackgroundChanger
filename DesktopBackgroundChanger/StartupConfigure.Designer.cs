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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 35);
            this.textBox1.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(583, 131);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(103, 47);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(571, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 33);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reddit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link:";
            // 
            // StartupConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.textBox1);
            this.Name = "StartupConfigure";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

