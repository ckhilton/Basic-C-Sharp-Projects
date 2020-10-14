using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            //CONSTANT KEYWORD EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
            const string casinoName = "GRAND HOTEL AND CASINO";

            //GLOBAL UNIQUE IDENTIFIER EXAMPLE
            Guid identifier = Guid.NewGuid();

            Console.WriteLine("WELCOME TO THE {0}. LET'S START BY TELLING ME YOUR NAME.", string.Format(casinoName));
            string playerName = Console.ReadLine().ToUpper();
            if (playerName == "ADMIN")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("PLEASE ENTER DIGITS ONLY, NO DECIMALS.");
            }


            //Console.WriteLine("AND HOW MUCH MONEY DID YOU BRING TODAY?");
            //int bank = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("HELLO, {0}. WOULD YOU LIKE TO JOIN A GAME OF 21 RIGHT NOW?", playerName);
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES" || answer == "YEAH" || answer == "Y" || answer == "YA" || answer == "YEA" || answer == "YEP" || answer == "YUP")
            {
                //INSTANTIATE PLAYER OBJECT 'player' AND REQUIRE TWO PARAMETERS
                Player player = new Player(name: playerName, beginningBalance: bank);

                //INSTANTIATE NEW GUID (GLOBAL UNIQUE IDENTIFIER) WITH THE 'Player' PROPERTY OF 'ID'
                player.ID = Guid.NewGuid();
                
                //LOG THE USERS NAME 
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Logs\TwentyOne_GameLog.txt", true)) //'true' APPENDS THE LIST, RATHER THAN OVERWRITING IT EACH TIME.
                {
                    file.WriteLine(player.ID);
                }               

                Game game = new TwentyOneGame(); //USES POLYMORPHISM
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0) //DOES PLAYER WANT TO KEEP PLAYING AND DO THEY HAVE ENOUGH MONEY TO PLAY
                {
                    
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
                    //BEGIN TRY-CATCH BLOCK FOR EXCEPTION HANDLING
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("AN ERROR HAS OCCURRED. PLEASE CONTACT YOUR SYSTEM ADMINISTRATOR.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    //END TRY-CATCH BLOCK
                }
                game -= player;
                Console.WriteLine("THANK YOU FOR PLAYING 21!");
            }
            Console.WriteLine("FEEL FREE TO LOOK AROUND THE CASINO. BYE FOR NOW.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //PARAMETERIZED QUERY

            using (SqlConnection connection = new SqlConnection(connectionString)) //DIFFERENT 'using' STATEMENT THAN AT THE TOP: A WAY OF MANAGING MEMORY WHEN DEALING WITH EXTERNAL RESOURCES
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //BY NAMING ITS DATATYPE YOU PROTECT AGAINST SQL INJECTIONS
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();  //INSERT STATEMENT
                connection.Close();

            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                //OPEN THE CONNECTION
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception); //GIVES ACCESS OUTSIDE THE USING STATEMENT
                }
                connection.Close();
            }

            return Exceptions;
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