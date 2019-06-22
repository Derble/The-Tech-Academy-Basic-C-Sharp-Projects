using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card //was public class card, doesn't inherit so struct is ok
    {
        //create properties of card

        //Constructor, assigns values upon creation
        /* //commented out during enum lesson
        public Card() //constructor method name is the name of the class
        {
            Suit = "Spades";
            Face = "Two";
        }
        */

        //card class has proerty of data type string called suit
        //you can get this property or set this property
        //public means it is accessible to other parts of the program


        //public string Suit { get; set; } //change string to suit once enum was added below
        public Suit Suit { get; set; } //changed because it is no longer a string, data type is now Suit


        //public string Face { get; set; }
        public Face Face { get; set; }
        //Card class now has two properties each of which is an enum

        //class is just a model, it's a design of an object
        //class is like a cookie cutter and an object is like a cookie
        //class is recipe, object is the food


        public override string ToString()//custom ToString method
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    //define enum, like defining a class but this one specifically relates to the card class so it's beneficial to define it in this class
    public enum Suit //data type name Suit
    {
        Clubs,//0
        Diamonds,//1
        Hearts,//2
        Spades//3
        //can assign whatever value you want to them like
        //Spades=15 etc
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
