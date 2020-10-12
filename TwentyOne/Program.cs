using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            ////WRITING TEXT TO FILE
            //string text = "here is some text.";
            //File.WriteAllText(@"C:\Users\Student\Desktop\log.txt", text); //THE '@' ALLOWS US TO USE JUST A SINGLE SLASH BECAUSE THE SLASH IS AN ESCAPE CHARACTER

            ////READING TEXT FROM A FILE
            //String text = File.ReadAllText(@"C:\Users\Student\Desktop\log.txt");
            //Console.WriteLine(text);

            //APPENDING TEXT: WE USE A STREAM



            Console.WriteLine("WELCOME TO THE GRAND HOTEL AND CASINO. LET'S START BY TELLING ME YOUR NAME.");
            string playerName = Console.ReadLine().ToUpper();
            Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("HELLO, {0}. WOULD YOU LIKE TO JOIN A GAME OF 21 RIGHT NOW?", playerName);
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES" || answer == "YEAH" || answer == "Y" || answer == "YA" || answer == "YEA" || answer == "YEP" || answer == "YUP")
            {
                Player player = new Player(name: playerName, beginningBalance: bank);
                Game game = new TwentyOneGame(); //USES POLYMORPHISM
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0) //DOES PLAYER WANT TO KEEP PLAYING AND DO THEY HAVE ENOUGH MONEY TO PLAY
                {
                    game.Play();
                    if (player.Balance <= 0)
                    {
                        if (player.IsBroke() == false)
                        {
                            player.IsActivelyPlaying = true;
                        }
                        else 
                        { 
                            player.IsActivelyPlaying = false; 
                        }
                    }
                    player.IsActivelyPlaying = true;
                }
                Console.WriteLine("THANK YOU FOR PLAYING 21!");
            }
            Console.WriteLine("FEEL FREE TO LOOK AROUND THE CASINO. BYE FOR NOW.");
            Console.Read();
        }
    }
}

//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Kirk";
//game = game + player;
//game = game - player;

//Deck deck = new Deck();
//deck.Shuffle(3);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
//}
//Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//Console.ReadLine();