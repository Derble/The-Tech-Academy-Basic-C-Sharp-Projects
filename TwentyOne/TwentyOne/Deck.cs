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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            //creates 2 lists and immediately instantiates them with values
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //card lowercase is a variable taht only exists inside of each loop, once it ends, it doesn't exist anymore which i why we can create it over and over again with the same name
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            //could do this 52 times to create the deck
        }

        public List<Card> Cards { get; set; }//property cards of data type List<Card>
    }
}
