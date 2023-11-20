using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using EveProfileSynchronizer.Core.Exception;
using EveProfileSynchronizer.Core.Model;
using Newtonsoft.Json;
using File = System.IO.File;

namespace EveProfileSynchronizer.Core
{
    internal class CacheHandler
    {
        private readonly string _cacheFolderPath;

        private readonly EsiDataProvider _esiDataProvider;

        private Dictionary<string, EveCharacter> _characterList;

        public CacheHandler()
        {
            _esiDataProvider = new EsiDataProvider();

            _cacheFolderPath = AppConfiguration.GetCacheFolderPath();
            
            CreateCacheFolder();
        }

        public Image GetCharacterPictureFromCache(int characterId)
        {
            var fileName = _cacheFolderPath + $"\\{characterId}.jpg";

            Image characterImage;

            if (!File.Exists(fileName))
            {
                characterImage = GetCharacterImageFromEveImageServer(characterId);
            }
            else
            {
                characterImage = Image.FromFile(fileName);
            }

            return characterImage;
        }

        public void SaveEveCacheObjectAsJson(EveCacheObject cacheObject)
        {
            var jsonOptionString = JsonConvert.SerializeObject(cacheObject);
            File.WriteAllText(AppConfiguration.GetCacheFolderPath() + "\\options.json", AppUtils.FormatJson(jsonOptionString));
        }

        public EveCacheObject LoadEveCacheObject(int[] characterIds)
        {
            if (!File.Exists(AppConfiguration.GetCacheFolderPath() + "\\options.json"))
            {
                throw new AppOptionFileNotFoundException();
            }

            var optionsString  = File.ReadAllText(AppConfiguration.GetCacheFolderPath() + "\\options.json");

            if (!ValidateOptionCache(characterIds, optionsString))
            {
                throw new AppOptionMissingIdException();
            }

            return JsonConvert.DeserializeObject<EveCacheObject>(optionsString);
        }

        public EveCacheObject CreateInitialEveCacheObject(int[] characterIds)
        {
            var result = _esiDataProvider.GetCharacterNamesJson(characterIds);
            var eveEsiResults =
                JsonConvert.DeserializeObject<List<EveEsiResult>>(result);

            List<EveCharacter> charactersCache = new List<EveCharacter>();

            foreach (var eveEsiResult in eveEsiResults)
            {
                var characterResult = _esiDataProvider.GetCharacterDetailsJson(characterId: eveEsiResult.id);
                var eveEsiCharacterResult = JsonConvert.DeserializeObject<EveEsiCharacterResult>(characterResult);

                int[] data = {
                    eveEsiCharacterResult.corporation_id,
                    eveEsiCharacterResult.alliance_id
                };

                var eveEsiCorpAllianceResult = _esiDataProvider.GetCharacterCorpAndAllianceName(data);
                var eveEsiCorpAllianceDetails = JsonConvert.DeserializeObject<List<EveEsiResult>>(eveEsiCorpAllianceResult);

                var character = new EveCharacter
                {
                    Id = eveEsiResult.id,
                    Name = eveEsiResult.name,
                    Corporation = eveEsiCorpAllianceDetails[0].name.Contains("#System") ? String.Empty : eveEsiCorpAllianceDetails[0].name,
                    Alliance = eveEsiCorpAllianceDetails[1].name.Contains("#System") ? String.Empty : eveEsiCorpAllianceDetails[1].name
                };

                charactersCache.Add(character);
            }

            var eveCacheObject = new EveCacheObject
            {
                Version = AppConfiguration.AppVersion,
                EveCharacters = charactersCache
            };

            SaveEveCacheObjectAsJson(eveCacheObject);

            return eveCacheObject;
        }

        public void ClearCache()
        {
            if (Directory.Exists(_cacheFolderPath))
            {
                Directory.Delete(_cacheFolderPath, true);
            }

            CreateCacheFolder();
        }

        private void CreateCacheFolder()
        {
            if (!Directory.Exists(_cacheFolderPath))
            {
                Directory.CreateDirectory(_cacheFolderPath);
            }
        }

        private Image GetCharacterImageFromEveImageServer(int characterId)
        {
            WebClient client = new WebClient();
            string characterImageUrl = $"https://images.evetech.net/characters/{characterId}/portrait?size={AppConfiguration.CharacterAvatarDefaultSize}";
            string fileName = _cacheFolderPath + $"\\{characterId}.jpg";

            client.DownloadFile(address: new Uri(characterImageUrl), fileName: fileName);

            return Image.FromFile(fileName);
        }

        private bool ValidateOptionCache(int[] characterIds, string optionsJsonString)
        {
            foreach (var characterId in characterIds)
            {
                if (!optionsJsonString.Contains(characterId.ToString()))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
