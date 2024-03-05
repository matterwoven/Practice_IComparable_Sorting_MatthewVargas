using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_MatthewVargas
{
    internal class Player : IComparable<Player>
    {
        public enum Job { Warrior, Cleric, Mage, Ranger }
        Job _playerJob;

        public Player(string name, Job job, int hp)
        {
            Random random = new Random();
            _playerJob = job;
            _name = name;
            if (_playerJob == Job.Warrior | _playerJob == Job.Cleric)
            {
                hp = random.Next(150) + 120;
            }
            else if (_playerJob == Job.Cleric)
            {
                hp = random.Next(130) + 120;
            }
            else if (_playerJob == Job.Mage | _playerJob == Job.Ranger)
            {
                hp = random.Next(60) + 50;
            }
            _hp = hp;

        }
        public string _name {get; set;}
        public int _hp { get; set;}

        public int CompareTo(Player? other)
        {
            return _name.CompareTo(other._name);
        }

        public override string ToString()
        {
            return $"{_name} - {_playerJob} - HP: {_hp}";
        }
    }
}
