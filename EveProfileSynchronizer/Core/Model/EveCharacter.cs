using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveProfileSynchronizer.Core.Model
{
    internal class EveCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Corporation { get; set; }
        public string Alliance { get; set; }
    }
}
