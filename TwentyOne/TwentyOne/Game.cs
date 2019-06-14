using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game //made public for other classes to access, generic name with only those properties specific to all games
    {
        public List<string> Players { get; set; } //all games have a list of players, names, a dealer
        public string Name { get; set; }
        public string Dealer { get; set; }
        public void ListPlayers()//not returning anything, just printing to console
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
