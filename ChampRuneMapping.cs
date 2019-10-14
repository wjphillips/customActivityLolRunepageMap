using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolChampionRunePageMap
{
    public class ChampRuneMapping : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> PageName { get; set; }

        [Category("Output")]
        public OutArgument<ChampRuneDataset> RuneData { get; set; }
        private Dictionary<string, ChampRuneDataset> GetChampRuneDataMatrix = new Dictionary<string, ChampRuneDataset>
        {
            {"XAYAH", new ChampRuneDataset("PRECISION", "INSPIRATION", new int[4]{2, 2, 1, 1}, new int[3]{2, 3, 0 }, new int[3] {2, 1, 2 })},
            {"TRISTANA", new ChampRuneDataset("PRECISION", "INSPIRATION", new int[4]{1, 2, 3, 1}, new int[3]{2, 3, 0 }, new int[3] {2, 1, 2 })},
            {"VAYNE", new ChampRuneDataset("PRECISION", "INSPIRATION", new int[4]{1, 2, 1, 1}, new int[3]{2, 3, 0 }, new int[3] {2, 1, 2 })},
            {"VAYNE2", new ChampRuneDataset("PRECISION", "SORCERY", new int[4]{1, 2, 1, 1}, new int[3]{0, 3, 3 }, new int[3] {2, 1, 2 })},
            {"ASHE", new ChampRuneDataset("PRECISION", "INSPIRATION", new int[4]{2, 2, 1, 1}, new int[3]{2, 3, 0 }, new int[3] {2, 1, 2 })},
            {"KAYN", new ChampRuneDataset("DOMINATION", "SORCERY", new int[4]{1, 3, 3, 1}, new int[3]{0, 2, 3 }, new int[3] {1, 1, 2 })},
            {"NAUTILUS", new ChampRuneDataset("RESOLVE", "INSPIRATION", new int[4]{2, 1, 3, 3}, new int[3]{0, 3, 1 }, new int[3] {3, 2, 1 })},
            {"THRESH", new ChampRuneDataset("RESOLVE", "INSPIRATION", new int[4]{2, 2, 3, 1}, new int[3]{0, 3, 1 }, new int[3] {3, 2, 1 })},
            {"NAMI", new ChampRuneDataset("SORCERY", "INSPIRATION", new int[4]{1, 2, 1, 1}, new int[3]{0, 3, 1 }, new int[3] {1, 1, 2 })}
        };
        

        protected override void Execute(CodeActivityContext context)
        {
            var pageName = PageName.Get(context).ToUpper();
            RuneData.Set(context, GetChampRuneDataMatrix[pageName]);
        }
    }
}
