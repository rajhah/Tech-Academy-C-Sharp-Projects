using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() 
        {
            // Cards is the List<Card> from below, the only property in this class
            Cards = new List<Card>();

            List<string> suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> faces = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            foreach (string suit in suits){
                foreach (string face in faces)
                {
                    Card card = new Card { Suit = suit, Face = face };
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Random random = new Random();
                List<Card> shuffledDeck = new List<Card>();
                while (this.Cards.Count > 0)
                {
                    //random number between 0 and deck.Cards count
                    int num = random.Next(0, this.Cards.Count);
                    //add the card at index n to the shuffledDeck list
                    shuffledDeck.Add(this.Cards[num]);
                    //remove the card from deck
                    this.Cards.RemoveAt(num);
                }
                this.Cards = shuffledDeck;
            }
        }
    }
}
