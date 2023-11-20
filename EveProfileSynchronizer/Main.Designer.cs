namespace EveProfileSynchronizer
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainCharacterDropDown = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.corporationLabel = new System.Windows.Forms.Label();
            this.allianceLabel = new System.Windows.Forms.Label();
            this.corporationTitelLabel = new System.Windows.Forms.Label();
            this.allianceTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTitleLable = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.syncCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.backupCountLabel = new System.Windows.Forms.Label();
            this.backupCountTitle = new System.Windows.Forms.Label();
            this.restoreTitleLabel = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.restoreBackupDropDown = new System.Windows.Forms.ComboBox();
            this.lastBackupLabel = new System.Windows.Forms.Label();
            this.lastBackupTitleLabel = new System.Windows.Forms.Label();
            this.isBackupNeededCheckBox = new System.Windows.Forms.CheckBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.clearCacheButton = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.GroupBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.dangerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteAllBackupsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.legalLabel = new System.Windows.Forms.Label();
            this.dangerZoneInfoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.optionsBox.SuspendLayout();
            this.commandBox.SuspendLayout();
            this.dangerGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCharacterDropDown
            // 
            this.mainCharacterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainCharacterDropDown.FormattingEnabled = true;
            this.mainCharacterDropDown.Location = new System.Drawing.Point(76, 19);
            this.mainCharacterDropDown.MaxDropDownItems = 99;
            this.mainCharacterDropDown.Name = "mainCharacterDropDown";
            this.mainCharacterDropDown.Size = new System.Drawing.Size(228, 21);
            this.mainCharacterDropDown.Sorted = true;
            this.mainCharacterDropDown.TabIndex = 0;
            this.mainCharacterDropDown.TabStop = false;
            this.mainCharacterDropDown.SelectedIndexChanged += new System.EventHandler(this.mainCharacterDropDown_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.corporationLabel);
            this.groupBox1.Controls.Add(this.allianceLabel);
            this.groupBox1.Controls.Add(this.corporationTitelLabel);
            this.groupBox1.Controls.Add(this.allianceTitleLabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.mainCharacterDropDown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select the character you wanna copy your profile from";
            // 
            // corporationLabel
            // 
            this.corporationLabel.AutoSize = true;
            this.corporationLabel.Location = new System.Drawing.Point(138, 49);
            this.corporationLabel.Name = "corporationLabel";
            this.corporationLabel.Size = new System.Drawing.Size(33, 13);
            this.corporationLabel.TabIndex = 7;
            this.corporationLabel.Text = "None";
            // 
            // allianceLabel
            // 
            this.allianceLabel.AutoSize = true;
            this.allianceLabel.Location = new System.Drawing.Point(138, 69);
            this.allianceLabel.Name = "allianceLabel";
            this.allianceLabel.Size = new System.Drawing.Size(33, 13);
            this.allianceLabel.TabIndex = 6;
            this.allianceLabel.Text = "None";
            // 
            // corporationTitelLabel
            // 
            this.corporationTitelLabel.AutoSize = true;
            this.corporationTitelLabel.Location = new System.Drawing.Point(73, 49);
            this.corporationTitelLabel.Name = "corporationTitelLabel";
            this.corporationTitelLabel.Size = new System.Drawing.Size(64, 13);
            this.corporationTitelLabel.TabIndex = 5;
            this.corporationTitelLabel.Text = "Corporation:";
            // 
            // allianceTitleLabel
            // 
            this.allianceTitleLabel.AutoSize = true;
            this.allianceTitleLabel.Location = new System.Drawing.Point(73, 69);
            this.allianceTitleLabel.Name = "allianceTitleLabel";
            this.allianceTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.allianceTitleLabel.TabIndex = 4;
            this.allianceTitleLabel.Text = "Alliance:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainTitleLable
            // 
            this.mainTitleLable.AutoSize = true;
            this.mainTitleLable.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLable.Location = new System.Drawing.Point(14, 9);
            this.mainTitleLable.Name = "mainTitleLable";
            this.mainTitleLable.Size = new System.Drawing.Size(229, 23);
            this.mainTitleLable.TabIndex = 4;
            this.mainTitleLable.Text = "EVE Profile Synchronizer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectAllCheckBox);
            this.groupBox2.Controls.Add(this.syncCheckedListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select all characters for the synchronization";
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(6, 250);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(137, 17);
            this.selectAllCheckBox.TabIndex = 2;
            this.selectAllCheckBox.Text = "Select All / Unselect All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // syncCheckedListBox
            // 
            this.syncCheckedListBox.CheckOnClick = true;
            this.syncCheckedListBox.FormattingEnabled = true;
            this.syncCheckedListBox.Location = new System.Drawing.Point(6, 18);
            this.syncCheckedListBox.Name = "syncCheckedListBox";
            this.syncCheckedListBox.Size = new System.Drawing.Size(303, 229);
            this.syncCheckedListBox.Sorted = true;
            this.syncCheckedListBox.TabIndex = 0;
            this.syncCheckedListBox.TabStop = false;
            this.syncCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.syncCheckedListBox_SelectedIndexChanged);
            // 
            // optionsBox
            // 
            this.optionsBox.Controls.Add(this.backupCountLabel);
            this.optionsBox.Controls.Add(this.backupCountTitle);
            this.optionsBox.Controls.Add(this.restoreTitleLabel);
            this.optionsBox.Controls.Add(this.restoreButton);
            this.optionsBox.Controls.Add(this.restoreBackupDropDown);
            this.optionsBox.Controls.Add(this.lastBackupLabel);
            this.optionsBox.Controls.Add(this.lastBackupTitleLabel);
            this.optionsBox.Controls.Add(this.isBackupNeededCheckBox);
            this.optionsBox.Location = new System.Drawing.Point(333, 139);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(200, 159);
            this.optionsBox.TabIndex = 6;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Options";
            // 
            // backupCountLabel
            // 
            this.backupCountLabel.AutoSize = true;
            this.backupCountLabel.Location = new System.Drawing.Point(68, 136);
            this.backupCountLabel.Name = "backupCountLabel";
            this.backupCountLabel.Size = new System.Drawing.Size(13, 13);
            this.backupCountLabel.TabIndex = 10;
            this.backupCountLabel.Text = "0";
            // 
            // backupCountTitle
            // 
            this.backupCountTitle.AutoSize = true;
            this.backupCountTitle.Location = new System.Drawing.Point(3, 136);
            this.backupCountTitle.Name = "backupCountTitle";
            this.backupCountTitle.Size = new System.Drawing.Size(52, 13);
            this.backupCountTitle.TabIndex = 9;
            this.backupCountTitle.Text = "Backups:";
            // 
            // restoreTitleLabel
            // 
            this.restoreTitleLabel.AutoSize = true;
            this.restoreTitleLabel.Location = new System.Drawing.Point(3, 39);
            this.restoreTitleLabel.Name = "restoreTitleLabel";
            this.restoreTitleLabel.Size = new System.Drawing.Size(87, 13);
            this.restoreTitleLabel.TabIndex = 8;
            this.restoreTitleLabel.Text = "Restore Backup:";
            // 
            // restoreButton
            // 
            this.restoreButton.ForeColor = System.Drawing.Color.Black;
            this.restoreButton.Location = new System.Drawing.Point(6, 82);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(95, 23);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Restore Profile";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // restoreBackupDropDown
            // 
            this.restoreBackupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restoreBackupDropDown.FormattingEnabled = true;
            this.restoreBackupDropDown.Location = new System.Drawing.Point(6, 55);
            this.restoreBackupDropDown.Name = "restoreBackupDropDown";
            this.restoreBackupDropDown.Size = new System.Drawing.Size(188, 21);
            this.restoreBackupDropDown.TabIndex = 0;
            this.restoreBackupDropDown.TabStop = false;
            // 
            // lastBackupLabel
            // 
            this.lastBackupLabel.AutoSize = true;
            this.lastBackupLabel.Location = new System.Drawing.Point(68, 113);
            this.lastBackupLabel.Name = "lastBackupLabel";
            this.lastBackupLabel.Size = new System.Drawing.Size(33, 13);
            this.lastBackupLabel.TabIndex = 4;
            this.lastBackupLabel.Text = "None";
            // 
            // lastBackupTitleLabel
            // 
            this.lastBackupTitleLabel.AutoSize = true;
            this.lastBackupTitleLabel.Location = new System.Drawing.Point(3, 113);
            this.lastBackupTitleLabel.Name = "lastBackupTitleLabel";
            this.lastBackupTitleLabel.Size = new System.Drawing.Size(70, 13);
            this.lastBackupTitleLabel.TabIndex = 3;
            this.lastBackupTitleLabel.Text = "Last Backup:";
            // 
            // isBackupNeededCheckBox
            // 
            this.isBackupNeededCheckBox.AutoSize = true;
            this.isBackupNeededCheckBox.Checked = true;
            this.isBackupNeededCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isBackupNeededCheckBox.Location = new System.Drawing.Point(6, 19);
            this.isBackupNeededCheckBox.Name = "isBackupNeededCheckBox";
            this.isBackupNeededCheckBox.Size = new System.Drawing.Size(157, 17);
            this.isBackupNeededCheckBox.TabIndex = 0;
            this.isBackupNeededCheckBox.Text = "Create Backup before Sync";
            this.isBackupNeededCheckBox.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(68, 65);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(63, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version: 1.0";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(47, 49);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(103, 13);
            this.creatorLabel.TabIndex = 0;
            this.creatorLabel.Text = "Created by: H4zz4rd";
            // 
            // clearCacheButton
            // 
            this.clearCacheButton.ForeColor = System.Drawing.Color.Black;
            this.clearCacheButton.Location = new System.Drawing.Point(6, 101);
            this.clearCacheButton.Name = "clearCacheButton";
            this.clearCacheButton.Size = new System.Drawing.Size(188, 23);
            this.clearCacheButton.TabIndex = 2;
            this.clearCacheButton.Text = "Clear Cache";
            this.clearCacheButton.UseVisualStyleBackColor = true;
            this.clearCacheButton.Click += new System.EventHandler(this.clearCacheButton_Click);
            // 
            // commandBox
            // 
            this.commandBox.Controls.Add(this.syncButton);
            this.commandBox.Location = new System.Drawing.Point(12, 415);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(315, 56);
            this.commandBox.TabIndex = 8;
            this.commandBox.TabStop = false;
            this.commandBox.Text = "3. Fire it up";
            // 
            // syncButton
            // 
            this.syncButton.Enabled = false;
            this.syncButton.Location = new System.Drawing.Point(6, 19);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(298, 23);
            this.syncButton.TabIndex = 0;
            this.syncButton.Text = "Start Synchronization";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // dangerGroupBox
            // 
            this.dangerGroupBox.Controls.Add(this.dangerZoneInfoLabel);
            this.dangerGroupBox.Controls.Add(this.deleteAllBackupsButton);
            this.dangerGroupBox.Controls.Add(this.label1);
            this.dangerGroupBox.Controls.Add(this.clearCacheButton);
            this.dangerGroupBox.ForeColor = System.Drawing.Color.Red;
            this.dangerGroupBox.Location = new System.Drawing.Point(333, 304);
            this.dangerGroupBox.Name = "dangerGroupBox";
            this.dangerGroupBox.Size = new System.Drawing.Size(200, 167);
            this.dangerGroupBox.TabIndex = 9;
            this.dangerGroupBox.TabStop = false;
            // 
            // deleteAllBackupsButton
            // 
            this.deleteAllBackupsButton.ForeColor = System.Drawing.Color.Red;
            this.deleteAllBackupsButton.Location = new System.Drawing.Point(6, 130);
            this.deleteAllBackupsButton.Name = "deleteAllBackupsButton";
            this.deleteAllBackupsButton.Size = new System.Drawing.Size(188, 23);
            this.deleteAllBackupsButton.TabIndex = 6;
            this.deleteAllBackupsButton.Text = " !!! Delete All Backups !!!";
            this.deleteAllBackupsButton.UseVisualStyleBackColor = true;
            this.deleteAllBackupsButton.Click += new System.EventHandler(this.deleteAllBackupsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANGER ZONE";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.legalLabel);
            this.infoGroupBox.Controls.Add(this.creatorLabel);
            this.infoGroupBox.Controls.Add(this.versionLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(333, 41);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(200, 92);
            this.infoGroupBox.TabIndex = 10;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info";
            // 
            // legalLabel
            // 
            this.legalLabel.AutoSize = true;
            this.legalLabel.Location = new System.Drawing.Point(30, 22);
            this.legalLabel.Name = "legalLabel";
            this.legalLabel.Size = new System.Drawing.Size(146, 13);
            this.legalLabel.TabIndex = 2;
            this.legalLabel.Text = "Software use at your own risk";
            // 
            // dangerZoneInfoLabel
            // 
            this.dangerZoneInfoLabel.AutoSize = true;
            this.dangerZoneInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.dangerZoneInfoLabel.Location = new System.Drawing.Point(19, 56);
            this.dangerZoneInfoLabel.Name = "dangerZoneInfoLabel";
            this.dangerZoneInfoLabel.Size = new System.Drawing.Size(157, 26);
            this.dangerZoneInfoLabel.TabIndex = 8;
            this.dangerZoneInfoLabel.Text = "In case of problems try to delete\r\n      the cache or backup files";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 479);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.dangerGroupBox);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mainTitleLable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVE Profile Synchronizer - v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            this.commandBox.ResumeLayout(false);
            this.dangerGroupBox.ResumeLayout(false);
            this.dangerGroupBox.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox mainCharacterDropDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainTitleLable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label allianceTitleLabel;
        private System.Windows.Forms.Label corporationTitelLabel;
        private System.Windows.Forms.CheckedListBox syncCheckedListBox;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.CheckBox isBackupNeededCheckBox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.GroupBox commandBox;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Label corporationLabel;
        private System.Windows.Forms.Label allianceLabel;
        private System.Windows.Forms.Button clearCacheButton;
        private System.Windows.Forms.Label lastBackupLabel;
        private System.Windows.Forms.Label lastBackupTitleLabel;
        private System.Windows.Forms.GroupBox dangerGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteAllBackupsButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label legalLabel;
        private System.Windows.Forms.Label restoreTitleLabel;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.ComboBox restoreBackupDropDown;
        private System.Windows.Forms.Label backupCountLabel;
        private System.Windows.Forms.Label backupCountTitle;
        private System.Windows.Forms.Label dangerZoneInfoLabel;
    }
}

