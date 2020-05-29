namespace MenuInterface
{
    partial class CraftMenu
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
            this.addButton = new System.Windows.Forms.Button();
            this.menuBox = new System.Windows.Forms.ListBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 33);
            this.addButton.TabIndex = 31;
            this.addButton.TabStop = false;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // menuBox
            // 
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Location = new System.Drawing.Point(24, 38);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(301, 199);
            this.menuBox.TabIndex = 30;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(179, 260);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(146, 33);
            this.confirmButton.TabIndex = 32;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(24, 299);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(149, 33);
            this.backButton.TabIndex = 33;
            this.backButton.TabStop = false;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CraftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 342);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuBox);
            this.Name = "CraftMenu";
            this.Text = "CraftMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox menuBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
    }
}