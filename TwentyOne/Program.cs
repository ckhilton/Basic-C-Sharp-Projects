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
            List<Person> employees = new List<Person>();
            Person person = new Person(); {  };
            employees.Add(person);


            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee = new Employee() { FirstName = "Sample ", LastName = "Student" };
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' CLASS OBJECT NAMED 'person'
            employee.Quit(employee); 
            
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


