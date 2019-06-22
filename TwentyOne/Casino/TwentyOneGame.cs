using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{   //to inherit from another class, add a colon and the name of the class you're inheriting from
    //class twentyonegame inherits from class game
    public class TwentyOneGame : Game, IWalkAway
    {
        //twentyone specific code

        public TwentyOneDealer Dealer { get; set; }//makes this Dealer specific to twentyonegame

        public override void Play() //override satisfies contract that we will define this method, abstract method so we have to have it
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();//new hand, don't want to carry over old hand
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();//dealer's hand is a new hand
            Dealer.Stay = false;
            Dealer.Deck = new Deck();//this makes it so that each round has a new deck, otherwise it would be a partial deck being used
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)//loop through each player and have them place a bet
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);//passing in the player's bet, will return true or false into successfullyBet
                if (!successfullyBet)//(successfullyBet == false) is another way to write it
                {
                    return; //end this method, won't return anything, goes back to while loop to repeat play method
                }
                Bets[player] = bet;//Bets represent dictionary, player is the key, added players name/object and bet to dictionary
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //console.write writes to console but does not automatically press enter
                    Dealer.Deal(player.Hand);
                    if (i == 1)//second turn, 2nd card passed out
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);//grabs the players bet from the bets table, player is the key to get the bet value
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Backjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }//iterates through dictionary and assign the dealer the balance of everything
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//check if busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//check for stay, either of these would break out of the while loop
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);//based off of bets table
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //List of players where their name equals the name in the dictionary
                    //looping through each key value pair, finding the player in the players list that matches that key value pair
                    //where the name equals the name we're loking for
                    //where produces a list
                    //First grabs the player in that list, only one player
                    //take players balance and add what they bet times 2
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            //loop through and compare all the players hands to the dealers hand
            foreach (Player player in Players)
            {   //bool? turns boolean data type into nullable boolean, can now have value null
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];//Bets[player] is just a key for the table, evaluates to an integer 
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            

            //throw new NotImplementedException(); //catch for accidentally calling that method until it is actually defined, not needed now that Play() is defined
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
