namespace MenuInterface
{
    partial class ItemMenu
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
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(12, 27);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(319, 251);
            this.itemListBox.TabIndex = 0;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(12, 295);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(101, 37);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(119, 295);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 37);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(229, 295);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(102, 37);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // ItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.itemListBox);
            this.Name = "ItemMenu";
            this.Text = "ItemMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button menuButton;
    }
}