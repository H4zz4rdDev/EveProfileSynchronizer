using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EveProfileSynchronizer.Core.Model;

namespace EveProfileSynchronizer.Core
{
    internal class BackupHandler
    {
        private readonly string _backupFolderPath;

        public BackupHandler()
        {
            _backupFolderPath = AppConfiguration.GetBackUpFolderPath();

            CreateBackUpFolder();

            GetLastBackupTimestamp();
        }

        public void CreateBackup(EveCacheObject eveCacheObject)
        {
            var currentTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            var backupFolderName = $"\\{currentTime}_{AppConfiguration.AppVersion}";

            if (!Directory.Exists(_backupFolderPath + backupFolderName))
            {
                Directory.CreateDirectory(_backupFolderPath + backupFolderName);
            }

            foreach (var eveCharacter in eveCacheObject.EveCharacters)
            {
                var profileFileName = $"\\core_char_{eveCharacter.Id}.dat";
                File.Copy(AppConfiguration.EveProfileFolderPath + profileFileName , _backupFolderPath + backupFolderName + profileFileName);
            }
        }

        public long GetLastBackupTimestamp()
        {
            var directoryInfo = new DirectoryInfo(_backupFolderPath);

            if (directoryInfo == null || !directoryInfo.Exists)
                return 0;

            var dir = directoryInfo.GetDirectories().OrderByDescending(f => f.LastWriteTime).FirstOrDefault();

            if(dir == null)
                return 0;

            return int.Parse(dir.Name.Split('_')[0]);
        }

        public void DeleteAllBackups()
        {
            Directory.Delete(path: _backupFolderPath, true);

            CreateBackUpFolder();
        }

        public List<string> GetBackupFileList()
        {
            var list = new List<string>();

            foreach (var directory in new DirectoryInfo(_backupFolderPath).GetDirectories())
            {
                list.Add(directory.Name);
            }

            return list;
        }

        private void CreateBackUpFolder()
        {
            if (!Directory.Exists(_backupFolderPath))
            {
                Directory.CreateDirectory(_backupFolderPath);
            }
        }
    }
}
