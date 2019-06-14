using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{   //to inherit from another class, add a colon and the name of the class you're inheriting from
    //class twentyonegame inherits from class game
    public class TwentyOneGame : Game
    {
        //twentyone specific code
        public void Play()
        {
            throw new NotImplementedException(); //catch for accidentally calling that method until it is actually defined
        }
    }
}
