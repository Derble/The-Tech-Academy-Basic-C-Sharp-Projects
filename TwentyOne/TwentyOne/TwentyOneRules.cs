using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //static bc don't want to create a TwentyOneRules object
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)//return int array of possible values
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//counts how many aces there are
            int[] result = new int[aceCount + 1];//standard format for reating array, pass in the value of how many there are
            int value = Hand.Sum(x => _cardValues[x.Face]);//takes each item and looks it up in the card values dictionary table, Face is the key here, then sums it
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)//start i at 1 since i at 0 is already in use above, result[0]
            {//for more than 1 ace, the value for the next ace is ten more
                //value = value + (i * 10);
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);//create int array of all possible values, pass in the current hand
            int value = possibleValues.Max();//gets maximum possible value
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();//if min value busts then all values are busted
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)//does dealer have possible hand values between 16 and 22 and if they do, return true so the dealer stays
                {
                    return true;
                }
                
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();//list of player results where int is less than 22 but also the largest that is less than 22
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
