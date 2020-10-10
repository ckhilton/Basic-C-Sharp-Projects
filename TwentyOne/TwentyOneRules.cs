using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //STATIC HERE BECAUSE WE DON'T WANT TO HAVE TO CREATE AN OBJECT TO ACCESS THIS (THEY ARE HELPER METHODS TO PERFORM SOME LOGIC WITHIN THE GAME)
        {
            [Face.TWO] = 2,
            [Face.THREE] = 3,
            [Face.FOUR] = 4,
            [Face.FIVE] = 5,
            [Face.SIX] = 6,
            [Face.SEVEN] = 7,
            [Face.EIGHT] = 8,
            [Face.NINE] = 9,
            [Face.TEN] = 10,
            [Face.JACK] = 10,
            [Face.QUEEN] = 10,
            [Face.KING] = 10,
            [Face.ACE] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.ACE);
            int[] result = new int[aceCount + 1]; //WHENEVER YOU CREATE AN ARRAY YOU HAVE TO STATE HOW BIG IT'S GOING TO BE OR HOW MANY POSSIBLE RESULTS THERE ARE
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); //THIS MULTIPLIES THE DEFAULT VALUE OF ACE (WHICH IS 1) BY 10, AND THEN ADDS 1 TO IT IN THE FOR LOOP. COULD HAVE ALSO BEEN WRITTEN OUT AS 'value = value + (i * 10);'
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand) //
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand) //AGAIN STATIC MAKES IT NOT ABLE TO CREATE AN OBJECT FROM THE METHOD
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand) //LOGIC FOR DEALER TO STAY IF HE HAS A HAND BETWEEN VALUES OF 16 AND 22
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
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
            //GET HIGHEST HAND THAT'S LESS THAN 22.
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}