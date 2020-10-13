using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player //*NOTE THAT CONSTRUCTORS GO AT THE VERY TOP OF THE CLASS
    {
        //CONSTRUCTOR CALL LINE
        public Player(string name) : this(name, 100)
        {
        }

        //CONSTRUCTOR
        public Player(string name, int beginningBalance)    //
        {                                                   //
            Hand = new List<Card>();                        // THIS WHOLE THING IS THE PLAYER OBJECT CONSTRUCTOR, WHICH USUALLY GOES ABOVE THE PROPERTIES LIST
            Balance = beginningBalance;                     //
            Name = name;                                    //
            Broke = false;
        }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid ID { get; set; }
        public bool Broke { get; set; }

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

        public bool IsBroke()
        {         
            Console.WriteLine("YOUR BALANCE IS {0}. YOU ARE BROKE!" +
            "\nWOULD YOU LIKE TO GO GET MORE MONEY FROM OUR ATM?", String.Format("{0:C}", Balance));
            string getMoney = Console.ReadLine().ToUpper();
            if (getMoney == "YES" || getMoney == "YEAH" || getMoney == "Y" || getMoney == "YA" || getMoney == "YEA" || getMoney == "YEP")
            {
                Console.WriteLine("HOW MUCH MONEY DID YOU GO GET?");
                int bank = Convert.ToInt32(Console.ReadLine());
                Balance = bank;              
                Console.WriteLine("YOUR BALANCE IS NOW: {0}" +
                    "\nWOULD YOU LIKE TO PLAY 21 AGAIN?", String.Format("{0:C}", Balance));
                string playAnswer = Console.ReadLine().ToUpper();
                if (playAnswer == "YES" || playAnswer == "YEAH" || playAnswer == "Y" || playAnswer == "YA" || playAnswer == "YEA" || playAnswer == "YEP")
                {
                    return false;
                }
            }
            return true;
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
