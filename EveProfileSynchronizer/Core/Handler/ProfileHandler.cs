using System.Collections.Generic;
using System.IO;
using System.Linq;
using EveProfileSynchronizer.Core.Configuration;
using EveProfileSynchronizer.Core.Model;

namespace EveProfileSynchronizer.Core.Handler
{
    internal class ProfileHandler
    {
        private readonly List<string> _fileBlackList = new List<string>();

        public ProfileHandler()
        {
            _fileBlackList.Add("core_char_('char', None, 'dat').dat");
            _fileBlackList.Add("core_char__.da");
            _fileBlackList.Add("core_user__.da");
        }

        public void DoProfileSync(EveCharacter mainCharacter, List<EveCharacter> syncCharacters)
        {
            var mainCharacterProfileFilename = $"\\core_char_{mainCharacter.Id}.dat";

            foreach (var character in syncCharacters)
            {
                var characterProfileFilename = $"\\core_char_{character.Id}.dat";

                if (!File.Exists(AppConfiguration.EveProfileFolderPath + characterProfileFilename))
                {
                    continue;
                }

                File.Delete(AppConfiguration.EveProfileFolderPath + characterProfileFilename);
                File.Copy(AppConfiguration.EveProfileFolderPath + mainCharacterProfileFilename,
                    AppConfiguration.EveProfileFolderPath + characterProfileFilename);
            }
        }

        public List<int> GetProfileCharacterIds()
        {
            var characterIds = new List<int>();

            var profileDirectory = new DirectoryInfo(AppConfiguration.EveProfileFolderPath);

            foreach (var file in profileDirectory.GetFiles())
            {
                if (!_fileBlackList.Any(file.Name.Contains) && Path.GetExtension(file.FullName) == ".dat")
                {
                    if (file.Name.Contains("core_char"))
                    {
                        characterIds.Add(int.Parse(Path.GetFileNameWithoutExtension(file.Name.Split('_')[2])));
                    }
                }
                
            }

            return characterIds;
        }
    }
}
