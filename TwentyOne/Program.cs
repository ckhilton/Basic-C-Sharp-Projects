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
            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee1 = new Employee();
            Employee employee2 = new Employee(); 
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' OBJECT
            employee1.FullName(FirstName: "Christopher", Full: out string Full1, LastName: "Hilton");
            employee2.FullName(FirstName: "Kirk", Full: out string Full2, LastName: "Hilton");

            if (employee1 == employee2)
            {
                Console.WriteLine(Full1 + " IS THE SAME EMPLOYEE AS " + Full2);
            }
            else
            {
                Console.WriteLine("THESE ARE TWO DIFFERENT EMPLOYEES");
            } 
         
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
//            Game game = new TwentyOneGame();
//            game.Players = new List<Player>();
//            Player player = new Player();
//            player.Name = "Kirk";
//            game += player; //SAME THING AS game = game + player;
//            game -= player; //SAME THING AS game = game - player;
//            Deck deck = new Deck();
//            deck.Shuffle(3);

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
//            }
//            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//            Console.ReadLine();
//        }
//    }
//}
