﻿using System;
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
            //INSTANTIATE OBJECT FROM CLASS CONSTRUCTOR 'Game()'
            //Game game = new Game();
            //game.Dealer = "Kirk";
            //game.Name = "TwentyOne";

            //INSTANTIATE 'TwentyOneGame' OBJECT FROM THE SUPERCLASS 'Game' (aka 'Game' CLASS IS INHERITED BY 'TwentyOneGame')
            //TwentyOneGame game = new TwentyOneGame();
            Game game = new Game();
            game.Players = new List<string>() { "Kirk", "Bill", "Joe" };
            game.ListPlayers();
            game.Play(); //THIS IS THE ONLY METHOD OR PROPERTY THAT IS SPECIFIC TO THE 'TwentyOneGame' CLASS (NOT ACCESSIBLE TO THE 'Game' METHOD 
            Console.ReadLine();
            
            //INSTANTIATE OBJECT FROM CLASS CONTSTRUCTOR 'Deck()'
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());                
            //}

            //Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
