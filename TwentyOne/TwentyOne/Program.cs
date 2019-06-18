using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //object initialization, initializes the new object with some values
            //Card card = new Card() { Face = "King", Suit = "Spades" };
            //card.Face = "King";
            //card.Suit = "Spades";

            //Game game = new Game();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";

            //TwentyOneGame game = new TwentyOneGame(); //since inherited from game class, has access to players property
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine(); //called the superclass method, whe you call a method from the class you're inheriting from, Game is the super class


            //Polymorphism property of classes to morph into other types of classes
            //a TwentyOneGame object can morph into a game object
            //TwentyOneGame can morph into another higher order object
            //Game game = new TwentyOneGame();

            //comes in handy when you want to make a list consisting of more than one data type
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);

            //TwentyOneGame
            //PokerGame
            //SolitaireGame

            //Game game = new Game(); //if game is abstract class, you can no longer instantiate it

            /*
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Zoe" };
            game.ListPlayers();
            Console.ReadLine();
            */
            /*
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();//had to add this in bc there was no list created yet to add a player into
            Player player = new Player();
            player.Name = "Jesse";
            //game = game + player;
            game += player; //easier way of writing game = game + player
            //game = game - player;
            game -= player;
            */

            //generics feature of language that allows you to write generic classes or functions, more generalized and less specific
            //list holds data type of whats being passed in. T generic

            //enum stuff
            //limit possible values you can receive from a user
            //DaysOfTheWeek day = DaysOfTheWeek.Monday;

            //enums continued
            Card card = new Card();
            card.Suit = Suit.Clubs;
            int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            Console.WriteLine(underlyingValue);

            Deck deck = new Deck();//create object deck
            //int timesShuffled = 0;
            //deck = Shuffle(deck, out timesShuffled, 3);//shuffles deck 3 times and returning the timesShuffled value, not returning it to deck, it's sending it out to the line above int timesSHuffled = 0;
            //deck = Shuffle(deck, 3); //shuffles deck 3 times
            deck.Shuffle(3);//call shuffle method 3 times, call method shuffle on itself
            
            /*
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            */
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
            
            //.NET does not support multiple inheritance, one class can only inherit from one other class
            //use interfaces

            //Methods have to be part of a class

            /* //commented out to create a constructor in deck class instead
            deck.Cards = new List<Card>();

            Card cardOne = new Card();
            //objects of data type card assigned to variable card one, created a new card object, instantiated a new object, currently empty
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";

            deck.Cards.Add(cardOne);//added one card to the deck

             //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            */
        }
        /*
        //public accessible everywhere, 
        //static bc we don't want to have to create an object program before calling this,
        //Deck is what it is returning, the type of data it is returning
        //Shuffle is the name of the function,
        //takes a parameter of type Deck and giving it the variable name deck for when we want to refer to it
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;

            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                //create a temporary list where we will store our shuffled items
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                //grab a random card take it out of a deck and put it into a temp deck
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);//random.Next takes a min and max value, between 0 and deck.cards.count
                    TempList.Add(deck.Cards[randomIndex]);//add to temp list
                    deck.Cards.RemoveAt(randomIndex);//delete it from list of Cards
                }
                deck.Cards = TempList;
            }

            return deck;
        }
        */
        //method for shuffling multiple times, overloading, uses same method name but is a little different, in this case 2 input parameters
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}//commented out when added int times = 1 to Shuffle above

        /*
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }//no need to use quotes, only possible values it can have
        */
    }
}
