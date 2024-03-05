namespace Practice_IComparable_Sorting_MatthewVargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> _players = new List<Player>();
            {
                _players.Add(new Player("John", Player.Job.Cleric, 0));
                _players.Add(new Player("David", Player.Job.Ranger, 0));
                _players.Add(new Player("StarLone", Player.Job.Mage, 0));
                _players.Add(new Player("Chris", Player.Job.Warrior, 0));
            };

            DisplayPlayers(_players, "Unsorted");

            _players.Sort();

            DisplayPlayers(_players, "By Name");

            PlayerSortJob psj = new PlayerSortJob();
            _players.Sort(psj);

            DisplayPlayers(_players, "By Job Order");

            _players.Sort(new PlayerSortHp());

            DisplayPlayers(_players, "By Hp");

            


        }
        public static void DisplayPlayers(List<Player> _players, string typeOfSort)
        {
            Console.WriteLine(typeOfSort);
            foreach (Player player in _players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("\n-------------------------------");


        }
    }


}
