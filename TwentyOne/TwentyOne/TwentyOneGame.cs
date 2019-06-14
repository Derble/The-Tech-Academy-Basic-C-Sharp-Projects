using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{   //to inherit from another class, add a colon and the name of the class you're inheriting from
    //class twentyonegame inherits from class game
    public class TwentyOneGame : Game, IWalkAway
    {
        //twentyone specific code
        public override void Play() //override satisfies contract that we will define this method
        {
            throw new NotImplementedException(); //catch for accidentally calling that method until it is actually defined
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }//TwentyOneGame does not HAVE A (HAS A) game, it IS A game, so inheritance is ok
}
