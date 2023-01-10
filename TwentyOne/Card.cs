using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = Suit.Spades;
            Face = Face.Q;
        }

        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        A=0,
        J=11,
        Q=12,
        K=13

        
    }
}
