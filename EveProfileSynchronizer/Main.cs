using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EveProfileSynchronizer.Core;

namespace EveProfileSynchronizer
{
    public partial class Main : Form
    {
        private EsiDataProvider _esiDataProvider;

        public Main()
        {
            InitializeComponent();

            _esiDataProvider = new EsiDataProvider();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] characterIds = new int[2];

            characterIds[0] = 95465499;
            characterIds[1] = 30000142;

            var result = _esiDataProvider.GetCharacterNames(characterIds);

            textBox1.Text = result.Content.ReadAsStringAsync().Result;
        }
    }
}
