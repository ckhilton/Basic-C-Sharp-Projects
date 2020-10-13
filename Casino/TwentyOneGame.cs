using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    //CREATE PUBLIC CLASS 'TwentyOneGame' THAT INHERITS THE SUPERCLASS 'Game' 
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() //'override' LETS US INHERIT THE CLASS 'Game' SINCE 'Play' IS AN ABSTRACT METHOD THAT MUST BE IMPLEMENTED FROM THE 'Game' SUPERCLASS
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
            Dealer.Deck.Shuffle();
            Console.WriteLine("PLACE YOUR BET!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //THIS DOESN'T RETURN ANYTHING, BUT RATHER IT ENDS THE METHOD
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("DEALING...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //THE NEXT THING AFTER 'Console.Write()' DOESN'T GO ONTO A NEW LINE.
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BLACKJACK! {0} WINS {1}\n", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Console.WriteLine("YOUR BALANCE IS NOW: {0}", String.Format("{0:C}", player.Balance));
                            break;
                        }
                    }
                    Console.Write("DEALER: ");
                    Dealer.Deal(Dealer.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("DEALER HAS BLACKJACK! EVERYONE LOSES!" +
                                "YOUR BALANCE IS NOW: {0}", string.Format("{0:C}", player.Balance));
                            foreach (KeyValuePair<Player, int> entry in Bets)
                            {
                                Dealer.Balance += entry.Value;
                            }                            
                            break;
                        }
                    }
                }              
            }

            foreach (Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("YOUR CARDS ARE: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHIT OR STAY?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "STAY" || answer == "S")
                    {
                        player.Stay = true;
                        break; //IF PLAYER DECIDES TO STAY, THE WHILE LOOP STOPS
                    }
                    else if (answer == "HIT" || answer == "H")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];                     
                        Console.WriteLine("SORRY {0}, YOU BUSTED! YOU LOST {1}. YOU HAVE {2} LEFT.", player.Name, string.Format("{0:C}", Bets[player]), string.Format("{0:C}", player.Balance));
                        if (player.Balance > 0)
                        {
                            Console.WriteLine("PLAY AGAIN?");
                            string again = Console.ReadLine().ToUpper();
                            if (again == "YES" || again == "YEAH" || again == "Y" || again == "YA" || again == "YEA" || again == "YEP" || again == "YUP")
                            {
                                player.IsActivelyPlaying = true;
                                return;
                            }
                            else
                            {
                                player.IsActivelyPlaying = false;
                                return;
                            }
                        }
                        return;
                    }
                }
            }
            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                Console.WriteLine("DEALER IS HITTING...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("DEALER IS STAYING.");
            }
            if (Dealer.IsBusted)
            {
                Console.WriteLine("DEALER BUSTED!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} WON {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //'bool?' MAKES THE BOOLEAN NULLABLE
                if (playerWon == null)
                {
                    Console.WriteLine("PUSH! NOBODY WINS.");
                    player.Balance += Bets[player]; //'Bets[player]' EVALUATES TO AN INTEGER AND BECOMES THE KEY FOR THE DICTIONARY VALUE
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} WON {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("DEALER WINS {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("PLAY AGAIN?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea" || answer == "yep")
                {
                    player.IsActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                    return;
                }
            }
           
        }
        //======================== END 'Play()' METHOD =========================


        public override void ListPlayers()
        {
            Console.WriteLine("21 PLAYERS: ");
            base.ListPlayers(); //THIS GETS AUTOGENERATED WHEN USING THE 'override' KEYWORD
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); //THROWS AN ERROR WHEN THE METHOD IS USED
        }
    }
}


//public override void Play() //'override' LETS US INHERIT THE CLASS 'Game' SINCE 'Play' IS AN ABSTRACT METHOD THAT MUST BE IMPLEMENTED FROM THE 'Game' SUPERCLASS
//{
//    throw new NotImplementedException(); //THROWS AN ERROR WHEN THE METHOD IS USED
//}
//public override void ListPlayers()
//{
//    Console.WriteLine("21 PLAYERS: ");
//    base.ListPlayers(); //THIS GETS AUTOGENERATED WHEN USING THE 'override' KEYWORD
//}
//public void WalkAway(Player player)
//{
//    throw new NotImplementedException(); //THROWS AN ERROR WHEN THE METHOD IS USED
//}