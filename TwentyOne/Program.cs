using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.Shuffle(8);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //Console.WriteLine("Players: " + game.Players.Count());

            Console.ReadLine();
        }
    }
}
