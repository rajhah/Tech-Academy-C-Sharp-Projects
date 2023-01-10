using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal static class TwentyOneRules
    {
        private static readonly Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.J] = 10,
            [Face.Q] = 10,
            [Face.K] = 10,
            [Face.A] = 1,
            [(Face)1] = 1,
            [(Face)2] = 2,
            [(Face)3] = 3,
            [(Face)4] = 4,
            [(Face)5] = 5,
            [(Face)6] = 6,
            [(Face)7] = 7,
            [(Face)8] = 8,
            [(Face)9] = 9,
            [(Face)10] = 10
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.A);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += 10;
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] values = GetAllPossibleHandValues(Hand);
            foreach (int i in values)
            {
                if (i > 16 && i < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerValues = GetAllPossibleHandValues(PlayerHand);
            int[] dealerValues = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerValues.Where(x => x < 22).Max();
            int dealerScore = dealerValues.Where(x => x < 22).Max();

            if (playerScore == dealerScore) return null;
            else return (playerScore > dealerScore);
        }
    }
}
