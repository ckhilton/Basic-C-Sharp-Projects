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

            try
            {
                Console.Write("ENTER HOW MANY YEARS OLD YOU ARE: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("ENTER THE MONTH OF THE YEAR YOU WERE BORN IN (AS A NUMBER): ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.Write("ENTER THE DAY OF THE MONTH YOU WERE BORN ON (AS A NUMBER): ");
                int day = Convert.ToInt32(Console.ReadLine());

                int year = 2020;

                DateTime bday = new DateTime(year, month, day);
                if (bday < DateTime.Now)
                {
                    int yearBorn = year - age;
                    Console.WriteLine("SINCE YOU TURNED {0} ON {1}, YOU WERE BORN IN THE YEAR {2}", age, bday, yearBorn);
                }
                if (bday > DateTime.Now)
                {
                    int yearBorn = year - age - 1;
                    Console.WriteLine("SINCE YOU TURN {0} ON {1}, YOU WERE BORN IN THE YEAR {2}", age, bday, yearBorn);
                }
            }
            catch (Exception ex)
            {
                (int age <= 0 || 0 <= month > 12 || 0 <= int day >= 31)
                      
            }
                
            Console.Read();
        }
            

                 
        }
    }
}
                //    //PRINTS THE CURRENT DATE AND TIME TO THE CONSOLE
                //    DateTime now = DateTime.Now;
                //    Console.WriteLine("CURRENT DATE AND TIME: {0}", now);

//    //ASKS USER FOR ANY NUMBER AND STORES AS A VALUE DATA TYPE DOUBLE NAMED 'answer'
//    Console.Write("\nPLEASE TYPE IN ANY NUMBER: ");
//    double answer = Convert.ToDouble(Console.ReadLine());

//    //CREATE NEW DATETIME CALLED 'future' AND USE THE METHOD 'AddHours' TO THE  VALUE OF 'now'
//    DateTime future = now.AddHours(answer);

//    //PRINTS THE EXACT TIME IT WILL BE IN X HOURS, WHERE X IS THE NUMBER THE USER ENTERED
//    Console.Write("\nIN {0} HOURS, THE EXACT DATE AND TIME WILL BE: " +
//        "\n\n\t\t{1}", answer, future);

//    Console.ReadLine();
//}


//            //CONSTANT KEYWORD EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
//            const string casinoName = "GRAND HOTEL AND CASINO";

//            //GLOBAL UNIQUE IDENTIFIER EXAMPLE
//            Guid identifier = Guid.NewGuid();

//            Console.WriteLine("WELCOME TO THE {0}. LET'S START BY TELLING ME YOUR NAME.", string.Format(casinoName));
//            string playerName = Console.ReadLine().ToUpper();

//            bool validAnswer = false;
//            int bank = 0;
//            while (!validAnswer)
//            {
//                Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
//                validAnswer = int.TryParse(Console.ReadLine(), out bank);
//                if (!validAnswer) Console.WriteLine("PLEASE ENTER DIGITS ONLY, NO DECIMALS.");
//            }


//            //Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
//            //int bank = Convert.ToInt32(Console.ReadLine());




//            Console.WriteLine("HELLO, {0}. WOULD YOU LIKE TO JOIN A GAME OF 21 RIGHT NOW?", playerName);
//            string answer = Console.ReadLine().ToUpper();
//            if (answer == "YES" || answer == "YEAH" || answer == "Y" || answer == "YA" || answer == "YEA" || answer == "YEP" || answer == "YUP")
//            {
//                //INSTANTIATE PLAYER OBJECT 'player' AND REQUIRE TWO PARAMETERS
//                Player player = new Player(name: playerName, beginningBalance: bank);

//                //INSTANTIATE NEW GUID (GLOBAL UNIQUE IDENTIFIER) WITH THE 'Player' PROPERTY OF 'ID'
//                player.ID = Guid.NewGuid();

//                //LOG THE USERS NAME 
//                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Logs\TwentyOne_GameLog.txt", true)) //'true' APPENDS THE LIST, RATHER THAN OVERWRITING IT EACH TIME.
//                {
//                    file.WriteLine(player.ID);
//                }               

//                Game game = new TwentyOneGame(); //USES POLYMORPHISM
//                game += player;
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
//                    //BEGIN TRY-CATCH BLOCK FOR EXCEPTION HANDLING
//                    try
//                    {
//                        game.Play();
//                    }
//                    catch (FraudException)
//                    {
//                        Console.WriteLine("CALL SECURITY!!! CHEATER ON THE FLOOR!!!");
//                        Console.ReadLine();
//                        return;
//                    }
//                    catch (Exception)
//                    {
//                        Console.WriteLine("AN ERROR HAS OCCURRED. PLEASE CONTACT YOUR SYSTEM ADMINISTRATOR.");
//                        Console.ReadLine();
//                        return;
//                    }
//                    //END TRY-CATCH BLOCK
//                }
//                game -= player;
//                Console.WriteLine("THANK YOU FOR PLAYING 21!");
//            }
//            Console.WriteLine("FEEL FREE TO LOOK AROUND THE CASINO. BYE FOR NOW.");
//            Console.Read();
//        }
//    }
//}

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