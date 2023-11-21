using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

namespace EveProfileSynchronizer.Core.Utils
{
    internal class AppUtils
    {
        public static string FormatJson(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        public static bool CheckIfEveIsRunning()
        {
            return Process.GetProcesses()
                .Any(p => p.MainWindowTitle.Contains("EVE Online Launcher") || p.MainWindowTitle.Contains("EVE -"));
        }
    }
}
