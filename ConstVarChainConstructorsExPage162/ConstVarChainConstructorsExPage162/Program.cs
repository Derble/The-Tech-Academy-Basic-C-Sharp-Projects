using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstructorsExPage162
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string greeting = "Hello and welcome to some game!";
            const string howToWin = "You need to have a total of over 1000 to win.";
            var amountNeededToWin = 1000;
            Console.WriteLine(greeting);
            Console.WriteLine(howToWin);

            startOfGame game = new startOfGame();
            
            Console.WriteLine("The starting amount is {0}.", game.startingAmount);
            Console.WriteLine("Your winnings are {0}.", game.winnings);
            var didYouWin = game.startingAmount + game.winnings;
            if (didYouWin > amountNeededToWin)
            {
                Console.WriteLine("Your total is {0}. You win!", didYouWin);
            }
            else
            {
                Console.WriteLine("Your total is {0}. You didn't win!", didYouWin);
            }

            Console.ReadLine();
        }

        public class startOfGame
        {
            
            public int startingAmount;
            public int winnings;
            
            public startOfGame() : this(500, 400)
            {

            }
            public startOfGame(int winnings, int startingAmount)
            {
                
                this.winnings = winnings;
                this.startingAmount = startingAmount;
                
            }
        }
    }
}
