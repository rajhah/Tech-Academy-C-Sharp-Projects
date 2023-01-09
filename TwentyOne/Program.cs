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

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player
            {
                Name = "Phil"
            };

            game += player;
            game -= player;
            
            Deck deck = new Deck();
            deck.Shuffle(8);

            Console.WriteLine("Players: " + game.Players.Count());

            Console.ReadLine();
        }
    }
}
