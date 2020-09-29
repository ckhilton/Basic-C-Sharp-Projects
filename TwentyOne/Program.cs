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
            //CREATE NEW EMPTY LIST CALLED 'names' FROM THE INHERITED PROPERTIES OF 'Person'
            List<Person> newlyHired = new List<Person>();
            //CREATE A NEW EMPLOYEE TO ADD TO THE LIST
            Employee name = new Employee();

            //GET USER INPUT
            Console.WriteLine("\n\tHELLO, WELCOME TO THE COMPANY!" +
                "\n\n\tPLEASE ENTER YOUR FIRST NAME: ");
            string inputFirst = Console.ReadLine();

            Console.WriteLine("\n" +
                "\n\tPLEASE ENTER YOUR LAST NAME: ");
            string inputLast = Console.ReadLine();

            //CALL ABSTRACT METHOD ON THE 'name' OBJECT
            name.FullName(FirstName: inputFirst.ToUpper(), out string Full, LastName: inputLast.ToUpper());
            //ADD NAME TO THE 'List<Person>' OF 'newlyHired' (USE POLYMORPHISM)
            newlyHired.Add(name);

            //DISPLAY INFO TO USER
            Console.WriteLine("HERE IS HOW YOUR NAME WILL APPEAR ON COMPANY RECORDS: " +
                "\n\n\t\t" + Full);

            name.Quit(name);
            


            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            //Employee employee = new Employee() { FirstName = "Sample ", LastName = "Student" };
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' CLASS OBJECT NAMED 'person'
            //employee.Quit(employee); 
            
            Console.ReadLine();          
        }
    }
}

//namespace TwentyOne
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //CREATE LIST
//            List<Game> games = new List<Game>();
//            TwentyOneGame game = new TwentyOneGame();
//            //ADD A 'game' TO THE LIST 'games' WHICH WILL USE POLYMORPHISM 
//            games.Add(game);

//            Deck deck = new Deck();
//            deck.Shuffle(3);

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
//            }
//            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//            Console.ReadLine();

//            ////INSTANTIATE 'TwentyOneGame' OBJECT FROM THE SUPERCLASS 'Game' (aka 'Game' CLASS IS INHERITED BY 'TwentyOneGame')
//            //TwentyOneGame game = new TwentyOneGame();            
//            //game.Players = new List<string>() { "Kirk", "Bill", "Joe" };
//            //game.ListPlayers();
//            //game.Play(); //THIS IS THE ONLY METHOD OR PROPERTY THAT IS SPECIFIC TO THE 'TwentyOneGame' CLASS (NOT ACCESSIBLE TO THE 'Game' METHOD)
//            //Console.ReadLine();

//        }
//    }
//}


