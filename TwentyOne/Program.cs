using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ////USING THE ENUM FROM 'Card' CLASS
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds; //CASTING THE ENUM TO IT'S UNDERLYING DATA TYPE (INT). THIS COULD HAVE ALSO BEEN WRITTEN OUT AS 'int underlyingValue = Convert.ToInt32(underlyingValue)'
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " OF " + card.Suit);
            }
            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            Console.ReadLine();
        }

        //DaysofTheWeek day = DaysofTheWeek.Monday;

        //public enum DaysofTheWeek
        //{
        //    Monday,
        //    Tuesday, 
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday, 
        //    Sunday
        //}
    }
}

//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Kirk";
//game += player; //SAME THING AS game = game + player;
//game -= player; //SAME THING AS game = game - player;

