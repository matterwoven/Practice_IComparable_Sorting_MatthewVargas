using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_MatthewVargas
{
    internal class PlayerSortHp : IComparer<Player>
    {
        //Always Descending order, Sorting Health Points
        public int Compare(Player x, Player y)
        {
            if (x._hp < y._hp) return -1;
            else if (x._hp > y._hp) return 1;
            else return 0;
        }
    }
}
