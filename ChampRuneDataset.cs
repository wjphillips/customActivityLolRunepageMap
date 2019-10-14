using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolChampionRunePageMap
{
    public class ChampRuneDataset
    {
        public string primaryTree { get; set; }
        public string secondaryTree { get; set; }
        public int[] primaryArray { get; set; }
        public int[] secondaryArray { get; set; }
        public int[] tertiaryArray { get; set; }
        public ChampRuneDataset(string priTree, string secTree, int[] priArray, int[] secArray, int[] tertArray)
        {
            primaryTree = priTree;
            secondaryTree = secTree;
            primaryArray = priArray;
            secondaryArray = secArray;
            tertiaryArray = tertArray;
        }
    }
}
