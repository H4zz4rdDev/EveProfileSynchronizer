using System;
using System.IO;

namespace EveProfileSynchronizer.Core.Configuration
{
    public static class AppConfiguration
    {
        public static int AppVersion = 1;
        public static int CharacterAvatarDefaultSize = 64;

        public static string ExePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public static string EveProfileFolderPath =
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "\\CCP\\EVE\\e_eve_online_tq_tranquility\\settings_Default";

        public static string GetCacheFolderPath()
        {
            return Path.Combine(Path.GetDirectoryName(ExePath) + "\\Cache");
        }

        public static string GetBackUpFolderPath()
        {
            return Path.Combine(Path.GetDirectoryName(ExePath) + "\\Backup");
        }
    }
}
