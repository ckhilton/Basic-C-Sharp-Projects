using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Person
    {       
        //PUBLIC STRING PROPERTIES 'FirstName' AND 'LastName'
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //PUBLIC VOID METHOD WITH NO INPUTS
        public void SayName()
        {
            //DISPLAY PERSONS FULL NAME TO THE CONSOLE
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}

//namespace TwentyOne
//{
//    public class Player
//    {
//        public List<Card> Hand { get; set; }
//        public int Balance { get; set; }
//        public string Name { get; set; }
//        public bool isActivelyPlaying { get; set; }

//        public static Game operator +(Game game, Player player)
//        {
//            game.Players.Add(player);
//            return game;
//        }
//        public static Game operator -(Game game, Player player)
//        {
//            game.Players.Remove(player);
//            return game;
//        }
//    }
//}
