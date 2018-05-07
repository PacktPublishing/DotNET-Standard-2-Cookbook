namespace Chapter7.Networking.IPListWindows
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(12, 32);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(187, 53);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Show IP List";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // IPListBox
            // 
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.ItemHeight = 25;
            this.IPListBox.Location = new System.Drawing.Point(12, 108);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(674, 429);
            this.IPListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 549);
            this.Controls.Add(this.IPListBox);
            this.Controls.Add(this.ShowButton);
            this.Name = "MainForm";
            this.Text = "IP List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListBox IPListBox;
    }
}

