using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)//giving this dealer object the ability to deal, takes as an input parameter a list of cards (Hand)
        {                               //in this method it will add a card to the Hand
                                        //works for any dealer, pass in a Hand and it will perform the below steps
            Hand.Add(Deck.Cards.First());//First is a method available to a list that takes the very first item in that list
            //logging
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            //Console.WriteLine(Deck.Cards.First().ToString() + "\n");//writing to the console the card that was dealt to the console
            Console.WriteLine(card); //changed for logging file i/o demo
            using (StreamWriter file = new StreamWriter(@"C:\Users\RX-78\Desktop\log.txt", true))//takes in a path, true is yes I want to append
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);//remove the card that was dealt from the deck. Remove at is a method that any list had, pass in an index of where you want to remove

        }
    }//inheritance is a IS A relationship, not a HAS A
    //Dealer HAS a Deck, not IS A Deck. That's why we don't want dealer class inheriting from Deck class
    //Deck is a class property since it is a HAS A relationship, keeps things aligned and more similar to real world
    //if unsure, just put it in as a property

    
}
