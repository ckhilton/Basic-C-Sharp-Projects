using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player //*NOTE THAT CONSTRUCTORS GO AT THE VERY TOP OF THE CLASS
    {
        //CONSTRUCTOR
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;

        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount) //TRY AND KEEP THE PLAYER LOGIC IN THE PLAYER CLASS. I.E. PLAYERS MAKE BETS
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("YOU DO NOT HAVE ENOUGH TO PLACE A BET THAT SIZE.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
