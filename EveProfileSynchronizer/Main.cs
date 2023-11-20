using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EveProfileSynchronizer.Core;
using EveProfileSynchronizer.Core.Exception;
using EveProfileSynchronizer.Core.Model;
using Newtonsoft.Json;

namespace EveProfileSynchronizer
{
    public partial class Main : Form
    {
        private EveProfileHandler _eveProfileHandler;

        private CacheHandler _cacheHandler;

        private BackupHandler _backupHandler;

        private EveCacheObject _eveCacheObject;

        private List<int> _characterIds;

        public Main()
        {
            InitializeComponent();

            _cacheHandler = new CacheHandler();
            _backupHandler = new BackupHandler();
            _eveProfileHandler = new EveProfileHandler();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _characterIds = new List<int>();
            _characterIds = _eveProfileHandler.GetProfileCharacterIds();

            try
            {
                _eveCacheObject = _cacheHandler.LoadEveCacheObject(_characterIds.ToArray());
            }
            catch (Exception ex) when (ex is AppOptionFileNotFoundException || ex is AppOptionMissingIdException)
            {
                _eveCacheObject = _cacheHandler.CreateInitialEveCacheObject(_characterIds.ToArray());
            }

            Init();

            SetLastBackupTimestamp();

            SetLastBackups();
        }

        private void Init()
        {
            foreach (var eveCharacter in _eveCacheObject.EveCharacters)
            {
                mainCharacterDropDown.Items.Add(eveCharacter.Name);
            }

            mainCharacterDropDown.SelectedIndex = 0;
        }

        private void mainCharacterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string characterName = (string)mainCharacterDropDown.SelectedItem;
            EveCharacter eveCharacter = _eveCacheObject.EveCharacters.ToList().First(c => c.Name.Contains(characterName));

            using (Image characterImage = _cacheHandler.GetCharacterPictureFromCache(eveCharacter.Id))
            {
                pictureBox1.Image = new Bitmap(characterImage);
            }

            corporationLabel.Text = eveCharacter.Corporation;
            allianceLabel.Text = eveCharacter.Alliance;

            syncCheckedListBox.Items.Clear();

            foreach (var character in _eveCacheObject.EveCharacters)
            {
                if(character.Name == characterName) continue;

                syncCheckedListBox.Items.Add(character.Name);
            }

            selectAllCheckBox.Checked = false;
        }

        private void syncCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasCheckedItems = syncCheckedListBox.CheckedItems.Count > 0;
            syncButton.Enabled = hasCheckedItems;
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (syncCheckedListBox.Items.Count <= 0) return;

            for (int i = 0; i < syncCheckedListBox.Items.Count; i++)
            {
                syncCheckedListBox.SetItemChecked(i, selectAllCheckBox.Checked);
            }

            bool hasCheckedItems = syncCheckedListBox.CheckedItems.Count > 0;
            syncButton.Enabled = hasCheckedItems;
        }

        private void clearCacheButton_Click(object sender, EventArgs e)
        {
            

            _cacheHandler.ClearCache();

            mainCharacterDropDown.Items.Clear();

            _eveCacheObject = _cacheHandler.CreateInitialEveCacheObject(_characterIds.ToArray());

            Init();
        }

        private void SetLastBackupTimestamp()
        {
            var lastBackupTime = _backupHandler.GetLastBackupTimestamp();
            lastBackupLabel.Text = lastBackupTime > 0 ? DateTimeOffset.FromUnixTimeSeconds(lastBackupTime).ToLocalTime().ToString("dd'/'MM'/'yyyy HH:mm:ss") : "none";
        }

        private void deleteAllBackupsButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete backups?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            _backupHandler.DeleteAllBackups();

            SetLastBackups();

            MessageBox.Show("All backups got deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            if (AppUtils.CheckIfEveIsRunning())
            {
                MessageBox.Show(
                    "EVE is running... "
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Please close the launcher and"
                    + Environment.NewLine
                    + "client first!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (isBackupNeededCheckBox.Checked)
            {
                _backupHandler.CreateBackup(_eveCacheObject);
            }

            // Todo Implement Sync Logic
            var mainCharacter = _eveCacheObject.EveCharacters.First(c => c.Name.Contains(mainCharacterDropDown.SelectedItem.ToString()));

            var syncCharacters = new List<EveCharacter>();

            foreach (var checkedItem in syncCheckedListBox.CheckedItems)
            {
                syncCharacters.Add(_eveCacheObject.EveCharacters.First(c => c.Name.Contains(checkedItem.ToString())));
            }

            _eveProfileHandler.DoProfileSync(mainCharacter, syncCharacters);

            MessageBox.Show("Synchronization Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SetLastBackups()
        {
            restoreBackupDropDown.Items.Clear();

            var backupList = _backupHandler.GetBackupFileList();
            if (backupList.Count <= 0)
            {
                restoreBackupDropDown.Enabled = false;
                return;
            }

            foreach (var backup in backupList)
            {
                var backupEntry = backup.Split('_')[0];
                restoreBackupDropDown.Items.Add(
                    DateTimeOffset.FromUnixTimeSeconds(long.Parse(backupEntry)).LocalDateTime.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
            }

            restoreBackupDropDown.Enabled = true;
            restoreBackupDropDown.SelectedIndex = restoreBackupDropDown.Items.Count - 1;
            backupCountLabel.Text = backupList.Count.ToString();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon....", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
