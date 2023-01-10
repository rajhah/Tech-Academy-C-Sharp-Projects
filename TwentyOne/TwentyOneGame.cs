using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3);
            
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }

            // Initial deal
            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}!", player.Name, Bets[player] * 1.5);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> keyValuePair in Bets)
                        {
                            Dealer.Balance += keyValuePair.Value;
                        }
                        return;
                    }
                }
            }
            // End initial deal

            // Start players hit/stay
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit (h) or stay (s)?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay" || answer == "s") 
                    { 
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "h")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}.", player.Name, Bets[player]);
                        Console.WriteLine("{0}'s balance is now: {1}", player.Name, player.Balance);
                        Console.WriteLine("Play again? (y/n)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "y") 
                        {
                            player.IsActivelyPlaying = true;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                        }
                        return;
                    }
                }
            }
            //end players hit/stay

            //Start dealer hit/stay
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying with:");
                foreach(Card card in Dealer.Hand)
                {
                    Console.WriteLine(card.ToString());
                }
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted!");
                foreach (KeyValuePair<Player, int> keyValuePair in Bets)
                {
                    Console.WriteLine("{0} won {1}!", keyValuePair.Key.Name, keyValuePair.Value);
                    Players.Where(x => x.Name == keyValuePair.Key.Name).First().Balance += (keyValuePair.Value * 2);
                    Console.WriteLine("{0}'s balance is now: {1}", keyValuePair.Key.Name, keyValuePair.Key.Balance);
                    Dealer.Balance -= keyValuePair.Value;
                }
                return;
            }
            //end dealer hit/stay
            
            //Start compare hands
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= (Bets[player]);
                    Console.WriteLine("{0}'s balance is now: {1}", player.Name, player.Balance);
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("{0}'s balance is now: {1}", player.Name, player.Balance);
                }
                Console.WriteLine("Play again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    player.IsActivelyPlaying = true;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                }
            }
            return;
            // end compare hands

        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}