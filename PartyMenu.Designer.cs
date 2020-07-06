namespace MenuInterface
{
    partial class PartyMenu
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.partyListBox = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(98, 280);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(96, 41);
            this.mainMenuButton.TabIndex = 0;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // partyListBox
            // 
            this.partyListBox.FormattingEnabled = true;
            this.partyListBox.Location = new System.Drawing.Point(22, 28);
            this.partyListBox.Name = "partyListBox";
            this.partyListBox.Size = new System.Drawing.Size(254, 199);
            this.partyListBox.TabIndex = 1;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(22, 233);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(96, 41);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(180, 233);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 41);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PartyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 334);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.partyListBox);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "PartyMenu";
            this.Text = "PartyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.ListBox partyListBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button backButton;
    }
}