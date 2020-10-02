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
            Console.WriteLine("\n\tPLEASE ENTER THE CURRENT DAY OF THE WEEK: \n\n\t");
            string input = /*"Wednesday";*/ Console.ReadLine();

            Day today;
            try
            {
                today = (Day)Enum.Parse(typeof(Day), input);
            

               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("PLEASE ENTER AN ACTUAL DAY OF THE WEEK");
                Console.WriteLine(ex.Message);

            }

            //if (today == Day
            //{
            //    Console.WriteLine("TODAY IS...");
            //}


            
            
            //int today = Convert.ToInt32(date.Day);
            //for (int i = 0; i < 7; i++)
            //{
            //    if (i == today)
            //    {
            //        Console.WriteLine("TODAY IS " + today);
            //    }
            //    else
            //    {
            //        Console.WriteLine("PLEASE ENTER AN ACTUAL DAY OF THE WEEK");
            //    }
            //}

            Console.ReadLine();
        }
    }
}


//int input = Enum.Parse(today.Day);


//Day weekday = Enum.TryParse(today);



////USING THE ENUM FROM 'Card' CLASS
//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = (int)Suit.Diamonds; //CASTING THE ENUM TO IT'S UNDERLYING DATA TYPE (INT). THIS COULD HAVE ALSO BEEN WRITTEN OUT AS 'int underlyingValue = Convert.ToInt32(underlyingValue)'
//Console.WriteLine(underlyingValue);

//Deck deck = new Deck();
//deck.Shuffle(3);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " OF " + card.Suit);
//}
//Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//Console.ReadLine();


//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Kirk";
//game += player; //SAME THING AS game = game + player;
//game -= player; //SAME THING AS game = game - player;

