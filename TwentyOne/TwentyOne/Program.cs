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

            Deck deck = new Deck();
            deck = Shuffle(deck);
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();



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

        //public accessible everywhere, 
        //static bc we don't want to have to create an object program before calling this,
        //Deck is what it is returning, the type of data it is returning
        //Shuffle is the name of the function,
        //takes a parameter of type Deck and giving it the variable name deck for when we want to refer to it
        public static Deck Shuffle(Deck deck)
        {
            //create a temporary list where we will store our shuffled items
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            //grab a random card take it out of a deck and put it into a temp deck
            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);//random.Next takes a min and max value, between 0 and deck.cards.count
                TempList.Add(deck.Cards[randomIndex]);//add to temp list
                deck.Cards.RemoveAt(randomIndex);//delete it from list of Cards
            }
            deck.Cards = TempList;
            return deck;
        }


    }
}
