namespace MenuInterface
{
    partial class PartMenu
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
            this.craftListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // craftListBox
            // 
            this.craftListBox.FormattingEnabled = true;
            this.craftListBox.Location = new System.Drawing.Point(12, 25);
            this.craftListBox.Name = "craftListBox";
            this.craftListBox.Size = new System.Drawing.Size(319, 251);
            this.craftListBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(119, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 37);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(229, 294);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(102, 37);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(12, 294);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(101, 37);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // PartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.craftListBox);
            this.Name = "PartMenu";
            this.Text = "PartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox craftListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button viewButton;
    }
}