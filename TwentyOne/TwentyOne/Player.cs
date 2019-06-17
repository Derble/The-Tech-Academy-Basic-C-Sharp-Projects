using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)//inside parentheses are what's being added together, adding  a game and a player and it is returning a Game(first Game in line)
        {                   //overloading the oeprator +, taking two operands game player and returning a game
            game.Players.Add(player); //game as a parameter, adds player to it and returns game
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);  //Players is a list, list have many different methods attached to them like remove
            return game;
        }
    }
}
