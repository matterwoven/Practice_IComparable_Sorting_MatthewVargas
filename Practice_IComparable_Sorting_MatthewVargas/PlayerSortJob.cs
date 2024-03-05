using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_MatthewVargas
{
    internal class PlayerSortJob : IComparer<Player>
    {
        Random random = new Random();
        public int Compare(Player x, Player y)
        {
            if (x != null || y != null) return 1;
            if (x == null || y == null) return 0;
            else return -1;
        }
    }
}
