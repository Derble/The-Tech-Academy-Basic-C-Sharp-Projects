using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //made public for other classes to access, generic name with only those properties specific to all games
    {
        public List<string> Players { get; set; } //all games have a list of players, names, a dealer
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();//method that is makred with abstract keyword, can only exist inside and abstract class, ab method contains no implementation
                                    //all it does is state that any class inheriting this class MUST implement this method

        public virtual void ListPlayers()//not returning anything, just printing to console
        {   //virtual method inside an abstract class, this method gets inherited by inheriting class but has ability to override it
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
    //abstract class can never be instantiated, never be an object, only meant to be inherited from, Game is an example of a base or abstract class
}
