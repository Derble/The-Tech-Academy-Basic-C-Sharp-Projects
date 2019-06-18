using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //constructors go at the top of the class before the properties
        public Deck()//constructor name is always the same as the class
        {
            Cards = new List<Card>();//instantiates property cards as an empty list of cards, Cards refers to the property of the class, so it doesn't need a data type

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting to Face inside parentheses
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }


            /*this portion rewritten during the enums part 2
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            //creates 2 lists and immediately instantiates them with values
            foreach (string face in Faces)
            {
                //commented out during enum lesson
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //card lowercase is a variable taht only exists inside of each loop, once it ends, it doesn't exist anymore which i why we can create it over and over again with the same name
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
                
            }
            */

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            //could do this 52 times to create the deck
        }

        public List<Card> Cards { get; set; }//property cards of data type List<Card>


        //public accessible everywhere, 
        //static bc we don't want to have to create an object program before calling this,
        //Deck is what it is returning, the type of data it is returning
        //Shuffle is the name of the function,
        //takes a parameter of type Deck and giving it the variable name deck for when we want to refer to it
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //create a temporary list where we will store our shuffled items
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                //grab a random card take it out of a deck and put it into a temp deck
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);//random.Next takes a min and max value, between 0 and deck.cards.count
                    TempList.Add(Cards[randomIndex]);//add to temp list
                    Cards.RemoveAt(randomIndex);//delete it from list of Cards
                }
                Cards = TempList;
            }

        }
    }
}
