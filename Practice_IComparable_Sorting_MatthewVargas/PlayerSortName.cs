using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_MatthewVargas
{
    internal class PlayerSortName : IComparer<Player>
    {
        //Always Descending order, Sorting Name
        public int Compare(Player x, Player y)
        {
            return x._name.CompareTo(y._name);
        }
    }
}
