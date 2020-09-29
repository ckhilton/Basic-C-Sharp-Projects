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
           
            //INSTANTIATE 'TwentyOneGame' OBJECT FROM THE SUPERCLASS 'Game' (aka 'Game' CLASS IS INHERITED BY 'TwentyOneGame')
            TwentyOneGame game = new TwentyOneGame();            
            game.Players = new List<string>() { "Kirk", "Bill", "Joe" };
            game.ListPlayers();
            game.Play(); //THIS IS THE ONLY METHOD OR PROPERTY THAT IS SPECIFIC TO THE 'TwentyOneGame' CLASS (NOT ACCESSIBLE TO THE 'Game' METHOD)
            Console.ReadLine();
            
        }
    }
}
