namespace MenuInterface
{
    partial class MainMenu
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
            this.PartyMembersFoundList = new System.Windows.Forms.ListBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InsertNameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.WeaponBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.meleeAttackBox = new System.Windows.Forms.TextBox();
            this.meleeDefenceBox = new System.Windows.Forms.TextBox();
            this.rangedAttackBox = new System.Windows.Forms.TextBox();
            this.rangedDefenceBox = new System.Windows.Forms.TextBox();
            this.movementSpeedBox = new System.Windows.Forms.TextBox();
            this.attackSpeedBox = new System.Windows.Forms.TextBox();
            this.HPLabel = new System.Windows.Forms.Label();
            this.meleeAttackLabel = new System.Windows.Forms.Label();
            this.meleeDefenceLabel = new System.Windows.Forms.Label();
            this.rangedAttackLabel = new System.Windows.Forms.Label();
            this.rangedDefenceLabel = new System.Windows.Forms.Label();
            this.movementSpeedLabel = new System.Windows.Forms.Label();
            this.attackSpeedLabel = new System.Windows.Forms.Label();
            this.partyButton = new System.Windows.Forms.Button();
            this.equipButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.craftButton = new System.Windows.Forms.Button();
            this.questButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartyMembersFoundList
            // 
            this.PartyMembersFoundList.FormattingEnabled = true;
            this.PartyMembersFoundList.ItemHeight = 25;
            this.PartyMembersFoundList.Location = new System.Drawing.Point(48, 128);
            this.PartyMembersFoundList.Name = "PartyMembersFoundList";
            this.PartyMembersFoundList.Size = new System.Drawing.Size(317, 129);
            this.PartyMembersFoundList.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(158, 33);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(207, 31);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(59, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(92, 70);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(154, 33);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // InsertNameLabel
            // 
            this.InsertNameLabel.AutoSize = true;
            this.InsertNameLabel.Location = new System.Drawing.Point(43, 319);
            this.InsertNameLabel.Name = "InsertNameLabel";
            this.InsertNameLabel.Size = new System.Drawing.Size(68, 25);
            this.InsertNameLabel.TabIndex = 5;
            this.InsertNameLabel.Text = "Name";
            this.InsertNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(137, 319);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(207, 31);
            this.NameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 9;
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(39, 367);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(92, 25);
            this.weaponLabel.TabIndex = 11;
            this.weaponLabel.Text = "Weapon";
            // 
            // WeaponBox
            // 
            this.WeaponBox.Location = new System.Drawing.Point(137, 367);
            this.WeaponBox.Name = "WeaponBox";
            this.WeaponBox.Size = new System.Drawing.Size(207, 31);
            this.WeaponBox.TabIndex = 10;
            this.WeaponBox.TextChanged += new System.EventHandler(this.WeaponBox_TextChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(210, 528);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(134, 33);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(137, 410);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(54, 31);
            this.hpBox.TabIndex = 13;
            // 
            // meleeAttackBox
            // 
            this.meleeAttackBox.Location = new System.Drawing.Point(137, 450);
            this.meleeAttackBox.Name = "meleeAttackBox";
            this.meleeAttackBox.Size = new System.Drawing.Size(54, 31);
            this.meleeAttackBox.TabIndex = 14;
            // 
            // meleeDefenceBox
            // 
            this.meleeDefenceBox.Location = new System.Drawing.Point(137, 491);
            this.meleeDefenceBox.Name = "meleeDefenceBox";
            this.meleeDefenceBox.Size = new System.Drawing.Size(54, 31);
            this.meleeDefenceBox.TabIndex = 15;
            // 
            // rangedAttackBox
            // 
            this.rangedAttackBox.Location = new System.Drawing.Point(137, 533);
            this.rangedAttackBox.Name = "rangedAttackBox";
            this.rangedAttackBox.Size = new System.Drawing.Size(54, 31);
            this.rangedAttackBox.TabIndex = 16;
            // 
            // rangedDefenceBox
            // 
            this.rangedDefenceBox.Location = new System.Drawing.Point(290, 413);
            this.rangedDefenceBox.Name = "rangedDefenceBox";
            this.rangedDefenceBox.Size = new System.Drawing.Size(54, 31);
            this.rangedDefenceBox.TabIndex = 17;
            // 
            // movementSpeedBox
            // 
            this.movementSpeedBox.Location = new System.Drawing.Point(290, 450);
            this.movementSpeedBox.Name = "movementSpeedBox";
            this.movementSpeedBox.Size = new System.Drawing.Size(54, 31);
            this.movementSpeedBox.TabIndex = 18;
            // 
            // attackSpeedBox
            // 
            this.attackSpeedBox.Location = new System.Drawing.Point(290, 491);
            this.attackSpeedBox.Name = "attackSpeedBox";
            this.attackSpeedBox.Size = new System.Drawing.Size(54, 31);
            this.attackSpeedBox.TabIndex = 19;
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(43, 410);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(41, 25);
            this.HPLabel.TabIndex = 20;
            this.HPLabel.Text = "HP";
            this.HPLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // meleeAttackLabel
            // 
            this.meleeAttackLabel.AutoSize = true;
            this.meleeAttackLabel.Location = new System.Drawing.Point(43, 450);
            this.meleeAttackLabel.Name = "meleeAttackLabel";
            this.meleeAttackLabel.Size = new System.Drawing.Size(71, 25);
            this.meleeAttackLabel.TabIndex = 21;
            this.meleeAttackLabel.Text = "MATK";
            // 
            // meleeDefenceLabel
            // 
            this.meleeDefenceLabel.AutoSize = true;
            this.meleeDefenceLabel.Location = new System.Drawing.Point(42, 491);
            this.meleeDefenceLabel.Name = "meleeDefenceLabel";
            this.meleeDefenceLabel.Size = new System.Drawing.Size(72, 25);
            this.meleeDefenceLabel.TabIndex = 22;
            this.meleeDefenceLabel.Text = "MDEF";
            // 
            // rangedAttackLabel
            // 
            this.rangedAttackLabel.AutoSize = true;
            this.rangedAttackLabel.Location = new System.Drawing.Point(43, 536);
            this.rangedAttackLabel.Name = "rangedAttackLabel";
            this.rangedAttackLabel.Size = new System.Drawing.Size(68, 25);
            this.rangedAttackLabel.TabIndex = 23;
            this.rangedAttackLabel.Text = "RATK";
            // 
            // rangedDefenceLabel
            // 
            this.rangedDefenceLabel.AutoSize = true;
            this.rangedDefenceLabel.Location = new System.Drawing.Point(215, 416);
            this.rangedDefenceLabel.Name = "rangedDefenceLabel";
            this.rangedDefenceLabel.Size = new System.Drawing.Size(69, 25);
            this.rangedDefenceLabel.TabIndex = 24;
            this.rangedDefenceLabel.Text = "RDEF";
            // 
            // movementSpeedLabel
            // 
            this.movementSpeedLabel.AutoSize = true;
            this.movementSpeedLabel.Location = new System.Drawing.Point(215, 453);
            this.movementSpeedLabel.Name = "movementSpeedLabel";
            this.movementSpeedLabel.Size = new System.Drawing.Size(73, 25);
            this.movementSpeedLabel.TabIndex = 25;
            this.movementSpeedLabel.Text = "MSPD";
            // 
            // attackSpeedLabel
            // 
            this.attackSpeedLabel.AutoSize = true;
            this.attackSpeedLabel.Location = new System.Drawing.Point(215, 494);
            this.attackSpeedLabel.Name = "attackSpeedLabel";
            this.attackSpeedLabel.Size = new System.Drawing.Size(69, 25);
            this.attackSpeedLabel.TabIndex = 26;
            this.attackSpeedLabel.Text = "ASPD";
            // 
            // partyButton
            // 
            this.partyButton.Location = new System.Drawing.Point(538, 46);
            this.partyButton.Name = "partyButton";
            this.partyButton.Size = new System.Drawing.Size(134, 33);
            this.partyButton.TabIndex = 28;
            this.partyButton.Text = "Party";
            this.partyButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.partyButton.UseVisualStyleBackColor = true;
            this.partyButton.Click += new System.EventHandler(this.partyButton_Click);
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(538, 100);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(134, 33);
            this.equipButton.TabIndex = 30;
            this.equipButton.Text = "Equip";
            this.equipButton.UseVisualStyleBackColor = true;
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(538, 151);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(134, 33);
            this.itemButton.TabIndex = 31;
            this.itemButton.Text = "Items";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // craftButton
            // 
            this.craftButton.Location = new System.Drawing.Point(538, 201);
            this.craftButton.Name = "craftButton";
            this.craftButton.Size = new System.Drawing.Size(134, 33);
            this.craftButton.TabIndex = 32;
            this.craftButton.Text = "Craft";
            this.craftButton.UseVisualStyleBackColor = true;
            this.craftButton.Click += new System.EventHandler(this.craftButton_Click);
            // 
            // questButton
            // 
            this.questButton.Location = new System.Drawing.Point(691, 46);
            this.questButton.Name = "questButton";
            this.questButton.Size = new System.Drawing.Size(134, 33);
            this.questButton.TabIndex = 33;
            this.questButton.Text = "Quests";
            this.questButton.UseVisualStyleBackColor = true;
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(691, 100);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(134, 33);
            this.partsButton.TabIndex = 34;
            this.partsButton.Text = "Parts";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(691, 151);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 33);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 586);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.questButton);
            this.Controls.Add(this.craftButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.partyButton);
            this.Controls.Add(this.attackSpeedLabel);
            this.Controls.Add(this.movementSpeedLabel);
            this.Controls.Add(this.rangedDefenceLabel);
            this.Controls.Add(this.rangedAttackLabel);
            this.Controls.Add(this.meleeDefenceLabel);
            this.Controls.Add(this.meleeAttackLabel);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.attackSpeedBox);
            this.Controls.Add(this.movementSpeedBox);
            this.Controls.Add(this.rangedDefenceBox);
            this.Controls.Add(this.rangedAttackBox);
            this.Controls.Add(this.meleeDefenceBox);
            this.Controls.Add(this.meleeAttackBox);
            this.Controls.Add(this.hpBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.WeaponBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertNameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PartyMembersFoundList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PartyMembersFoundList;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label InsertNameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.TextBox WeaponBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox hpBox;
        private System.Windows.Forms.TextBox meleeAttackBox;
        private System.Windows.Forms.TextBox meleeDefenceBox;
        private System.Windows.Forms.TextBox rangedAttackBox;
        private System.Windows.Forms.TextBox rangedDefenceBox;
        private System.Windows.Forms.TextBox movementSpeedBox;
        private System.Windows.Forms.TextBox attackSpeedBox;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Label meleeAttackLabel;
        private System.Windows.Forms.Label meleeDefenceLabel;
        private System.Windows.Forms.Label rangedAttackLabel;
        private System.Windows.Forms.Label rangedDefenceLabel;
        private System.Windows.Forms.Label movementSpeedLabel;
        private System.Windows.Forms.Label attackSpeedLabel;
        private System.Windows.Forms.Button partyButton;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button craftButton;
        private System.Windows.Forms.Button questButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button saveButton;
    }
}

