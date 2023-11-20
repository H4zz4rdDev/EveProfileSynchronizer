using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveProfileSynchronizer.Core.Model
{
    internal class EveCacheObject
    {
        public int Version;
        public List<EveCharacter> EveCharacters;
    }
}
