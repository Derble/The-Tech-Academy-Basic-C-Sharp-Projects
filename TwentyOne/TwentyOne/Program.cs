using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player newPlayer = new Player("Jesse");
            //var keyword instead of player lets you implicitly define the variable
            //var newPlayer = new Player("Jesse");
            const string casinoName = "The Great Northern Hotel and Casino";//nice to have to reuse in other code so that name can't be changed

            //Guid identifier = new Guid();
            //Guid identifier = Guid.NewGuid();//creates a globally unique identifier

            //namespace is a way to organize your code


            //datetime demo
            //datetime is a struct so it is not nullable
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);//create new datetime object
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;//gives the difference in days



            //I/O demo, writing text to file
            //writing text
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\RX-78\Desktop\log.txt", text);//@ symbol read string exactly as it is
            //reading text
            //string text = File.ReadAllText(@"C:\Users\RX-78\Desktop\log.txt");
            //other log code on Dealer

            //Putting it all together page 141, commented out everything and are creating a new main method, new code
            Console.WriteLine("Welcome to {0} and Casino. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)//will get hit since validAnswer is false
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);//same as Int32.TryParse(),string in is console.readline, out paramter is bank
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");

            }

            /*//replaced with code above
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            */

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();//makes whatever they asnwer as all lower case

            if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")//|| is or
            {
                Player player = new Player(playerName, bank);//sends playerName and bank to Player constructor in Player class
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\RX-78\Desktop\log.txt", true))//takes in a path, true is yes I want to append
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();//polymorphism, exposes the overloaded operators for use
                game += player; //adding player to the game
                player.isActivelyPlaying = true; //isActivelyPlaying is a property of player
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)//Exception is a generic exception, will catch all exceptions with that
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator");
                        Console.ReadLine();
                        return; //return in a void method returns nothing so it ends the method
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the Casino. Bye for now.");
            Console.Read();


            //-------------------------------------------------------------------------old code
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
            //can cast an enum to its underlying integer
            /*//enums continued
            Card card = new Card();
            card.Suit = Suit.Clubs;
            int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            Console.WriteLine(underlyingValue);
            */

            //reference types are like doc on google drive, really same doc since it is the same memory location, when card 2 edits, changes card 1 also
            //any data type that stores value by reference is called a reference type, general rule of thumb, this includes all classes
            //string, List, Card are a reference type
            /*
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;
            */
            //by changing Card class to struct, Eight is displayed rather than King since it is no longer reference
            //card1 is now its own separate instance

            //value type - if a copy is sent by email rather than using google drive, that's like sending by value, separate independent instance, not pointing to storage location, sending actual value
            //value type examples - integers, booleans, enums, datetime
            //int is a public struct, Int32 could be used in place of int
            //int number = 5;
            //Int32 number = 5; same thing
            //struct is the same as a class but is a value type, struct can't be inherited
            //struct is a value type, value type can't be null because they are non-nullable
            //non-nullable data types are structs, booleans, integers
            //Console.WriteLine(card1.Face);

            //lambda functions 
            //very difficult to debug since you can't step through it like a loop

            //Deck deck = new Deck();//create object deck

            /*
            //count number of Aces in deck using lambda function
            int count = deck.Cards.Count(x => x.Face == Face.Ace);//Cards is a List, Count is a lambda function
            //counting all the elements (x) in the List, x is each element where x.Face is equal to Face.Ace, x can be renamed to anything
            // => means "map this expression to each item"
            Console.WriteLine(count);
            */

            /*
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();//where is lambda function that lets you filter your list for particular features
            //doesn't produce a list so have to use ToList()
            //take list of cards, filter where face is king, map that to a new list
            foreach (Card card in newList)
            {
                Console.WriteLine(card.Face);
            }
            */

            /*
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //int sum = numberList.Sum(); //or could add more arithmetic like the line below
            //int sum = numberList.Sum(x => x + 5);
            //int sum = numberList.Max();
            //int sum = numberList.Min();
            int sum = numberList.Where(x => x > 20).Sum();//have to add Sum() since numberList.Where(x => x > 20) wouldn't do anything
            Console.WriteLine(sum);
            */

            /*//count number of aces in deck using for loop
            int counter = 0;
            foreach (Card card in deck.Cards)
            {
                if (card.Face == Face.Ace)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            */

            /*
            //int timesShuffled = 0;
            //deck = Shuffle(deck, out timesShuffled, 3);//shuffles deck 3 times and returning the timesShuffled value, not returning it to deck, it's sending it out to the line above int timesSHuffled = 0;
            //deck = Shuffle(deck, 3); //shuffles deck 3 times
            deck.Shuffle(3);//call shuffle method 3 times, call method shuffle on itself
            
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
           
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled);
            */
            //Console.ReadLine();

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
