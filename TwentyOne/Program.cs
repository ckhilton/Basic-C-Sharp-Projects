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
            ////CREATE LIST
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            ////ADD A 'game' TO THE LIST 'games' WHICH WILL USE POLYMORPHISM 
            //games.Add(game);


            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Kirk", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
            //}
            //Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            //Console.ReadLine();

            ////INSTANTIATE 'TwentyOneGame' OBJECT FROM THE SUPERCLASS 'Game' (aka 'Game' CLASS IS INHERITED BY 'TwentyOneGame')
            //TwentyOneGame game = new TwentyOneGame();            
            //game.Players = new List<string>() { "Kirk", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play(); //THIS IS THE ONLY METHOD OR PROPERTY THAT IS SPECIFIC TO THE 'TwentyOneGame' CLASS (NOT ACCESSIBLE TO THE 'Game' METHOD)
            //Console.ReadLine();
            
        }
    }
}
