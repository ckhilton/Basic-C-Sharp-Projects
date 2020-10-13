using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            //CONSTANT KEYWORD VARIABLE EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
            const string company = "HILTON CONSULTING CORPORATION";
            Console.WriteLine("WELCOME TO THE {0} EMPLOYEE PORTAL." +
                "\n\nSINCE THIS IS YOUR FIRST TIME, PLEASE CHOOSE A UNIQUE NUMBER FOR YOUR EMPLOYEE ACCESS ID...", company);

            //STORE USER INPUT IN VARIABLES USING 'var' KEYWORD
            Console.Write("ENTER YOUR UNIQUE {0} EMPLOYEE ACCESS ID HERE: ", company);
            var id = Convert.ToInt32(Console.ReadLine());

            //USE CHAINED CONSTRUCTORS
            var employee = new Employee(id);

            Console.Write("ENTER YOUR FIRST NAME: ");
            employee.First = Console.ReadLine().ToUpper();

            Console.Write("ENTER YOUR LAST NAME: ");
            employee.Last = Console.ReadLine().ToUpper();

            Console.Write("ENTER YOUR DOB: ");
            employee.DOB = Console.ReadLine().ToUpper();

            Console.Write("IS EVERY FIELD ABOVE FILLED OUT? (Y/N)");
            string answer = Console.ReadLine().ToUpper();

            StreamWriter file = new StreamWriter(@"C:\);
            {
                Console.
            }

            bool display = (answer == "Y");
            if (display)
            {
                employee.Valid = true;
                employee.Display();           
            }
            else return;

            Console.ReadKey(true);
        }
    }
}

//ADDITIONAL FEATURES OF C# VIDEO PART1
//CONSTRUCTOR CALL LINES

////Player newPlayer = new Player("Kirk"); //FROM CONSTRUCTOR CALL CHAIN (I.E. "CHAINING) USED IN THE 'Player' CLASS
////SHORTENED VERSION OF THE SAME CODE USED BELOW WITH THE 'var' DATA TYPE
//var newPlayer = new Player("Kirk");

//Dictionary<string, string> newDictionary = new Dictionary<string, string>();
////                      OR
//var newDictionary = new Dictionary<string, string>();



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



//GLOBAL UNIQUE IDENTIFIER EXAMPLE
//Guid identifier = Guid.NewGuid();

//Console.WriteLine("WELCOME TO THE {0}. LET'S START BY TELLING ME YOUR NAME.", string.Format(casinoName));
//            string playerName = Console.ReadLine().ToUpper();
//Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
//            int bank = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("HELLO, {0}. WOULD YOU LIKE TO JOIN A GAME OF 21 RIGHT NOW?", playerName);
//            string answer = Console.ReadLine().ToUpper();
//            if (answer == "YES" || answer == "YEAH" || answer == "Y" || answer == "YA" || answer == "YEA" || answer == "YEP" || answer == "YUP")
//            {
//                Player player = new Player(name: playerName, beginningBalance: bank) { ID = Guid.NewGuid() };
//                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Logs\TwentyOne_GameLo.txt", true))
//                {
//                    file.WriteLine(player.ID);
//                }

//                Game game = new TwentyOneGame(); //USES POLYMORPHISM
//game += player;
//                player.IsActivelyPlaying = true;
//                while (player.IsActivelyPlaying && player.Balance > 0) //DOES PLAYER WANT TO KEEP PLAYING AND DO THEY HAVE ENOUGH MONEY TO PLAY
//                {
                    
//                    if (player.Balance <= 0)
//                    {
//                        if (player.IsBroke() == false)
//                        {
//                            player.IsActivelyPlaying = true;
//                        }
//                        else 
//                        { 
//                            player.IsActivelyPlaying = false; 
//                        }
//                    }
//                    game.Play();
//                }
//                //game -= player;
//                Console.WriteLine("THANK YOU FOR PLAYING 21!");
//            }
//            Console.WriteLine("FEEL FREE TO LOOK AROUND THE CASINO. BYE FOR NOW.");