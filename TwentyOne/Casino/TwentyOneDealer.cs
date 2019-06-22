using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne //anything having to do with dealer will be in the twentyone subsection of casino
{
    public class TwentyOneDealer : Dealer
    {
        //TwentyOneDealer inherits from Dealer class, but needs some extra things like a Hand, so this new class is needed

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}
