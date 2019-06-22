using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //Player constructor that takes one parameter added for additional features part one page 160
        public Player(string name) : this(name, 100)//assign name to Name but if they don't provide a beginning balance, auto assign 100
        {
            //no implementation needed because code is being reused from other constructor
            //reusing constructor, called constructor chaining or creating a constructor call chain
        }

        //Player constructor
        public Player(string name, int beginningBalance)//taking 2 arguments
        {
            Hand = new List<Card>();
            Balance = beginningBalance;//assigning args to properties in the class (below)
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                //Balance = Balance - amount;
                Balance -= amount;
                return true;
            }
        }
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
