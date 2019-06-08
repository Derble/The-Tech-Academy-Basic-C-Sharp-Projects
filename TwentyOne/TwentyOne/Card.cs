using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //create properties of card

            //Constructor, assigns values upon creation
        public Card() //constructor method name is the name of the class
        {
            Suit = "Spades";
            Face = "Two";
        }

            //card class has proerty of data type string called suit
            //you can get this property or set this property
            //public means it is accessible to other parts of the program
        public string Suit { get; set; }
        public string Face { get; set; }

            //class is just a model, it's a design of an object
            //class is like a cookie cutter and an object is like a cookie
            //class is recipe, object is the food
    }
}
