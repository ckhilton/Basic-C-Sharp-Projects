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
            bool run = true;
            
            //CONSTANT KEYWORD VARIABLE EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
            const string company = "HILTON CONSULTING CORPORATION";
            Console.WriteLine("WELCOME TO THE {0} EMPLOYEE PORTAL." +
                "\n\nTHIS IS YOUR FIRST TIME ACCESSING THE SYSTEM, LET'S GET YOU SET UP!" +
                "\n\nPLEASE ENTER THE FOLLOWING INFORMATION:", company);
            do
            {
                //STORE USER INFO/INPUT IN VARIABLES USING 'var' KEYWORD
                Console.Write("\nA UNIQUE 4-DIGIT ONLINE ACCESS ID HERE (DON'T FORGET): ");
                var access = Convert.ToInt32(Console.ReadLine());

                Console.Write("FIRST NAME: ");
                var first = Console.ReadLine().ToUpper();

                Console.Write("LAST NAME: ");
                var last = Console.ReadLine().ToUpper();

                Console.Write("YOUR DOB: ");
                var dob = Console.ReadLine().ToUpper();

                //USE CHAINED 'Employee' CONSTRUCTORS THAT DISPLAY A DEFAULT A MESSAGE ABOUT THE EMPLOYEES DEPARTMENT NAME
                var employee = new Employee(access, first, last, dob);
                List<string> all = employee.Full;
                
                Console.Write("\nWE WILL NOW PROCEED TO VERIFY AND STORE YOUR INFORMATION." +
                    "\n\nTHIS INFORMATION IS KEPT PRIVATE IN OUR EMPLOYEE RECORDS." +
                    "\n\n\tTYPE \"Y\" IF YOU UNDERSTAND AND AGREE TO CONTINUE." +
                    "\n\tTYPE \"N\" IF YOU WISH TO STOP AND EXIT THE PROGRAM." +
                    "\n\n\tANSWER: (\"Y\" OR \"N\") ");
                string answer = Console.ReadLine().ToUpper();               

                //CONTROL CONDITIONS FOR VERIFYING INFO
                bool display = (answer == "Y");
                if (display)
                {
                    //CALL 'Verify' METHOD
                    employee.Verify();
                    //INSTANTIATE NEW OBJECT OF CLASS 'StreamWriter'
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Logs\EmployeeLog.txt", true)) ; //'true' ALLOWS 'file' TO BE APPENDED INSTEAD OF OVERWRITTEN
                    //INSTANTIATE NEW GUID (GLOBAL UNIQUE IDENTIFIER) WITH THE 'Employee' PROPERTY OF 'EmpID'
                    file.WriteLine(EmpID);
                    //LOG ALL VALUES IN THE LIST PROPERTY 'Full' THAT ARE IN THE 'Employee' CLASS OBJECT 'employee' AND 
                    foreach (string value in all)
                    {                        
                        file.WriteLine(value);                     
                    }
                    Console.WriteLine("\nYOUR ONLINE EMPLOYEE SETUP IS COMPLETE!!!");
                    break;
                }
                if (!display && answer != "N")
                {
                    break;
                }
                if (!display)
                {
                    run = true;
                }
            }
            //DO-WHILE LOOP RUNS IF USER ANSWERS 'N' AND NEEDS TO CHANGE INFO 
            while (run);
            Console.ReadLine();
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