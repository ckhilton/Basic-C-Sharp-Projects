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
            //USER INSTRUCTIONS 
            Console.WriteLine("\tWE BELIEVE WE HAVE DUPLICATE EMPLOYEE RECORDS FOR YOU. " +
                "\n\n\tPLEASE FILL OUT THE FOLLOWING FOR THE FIRST RECORD:");
            //GET USER INPUT FOR FIRST NAME
            Console.WriteLine("\n\tYOUR LEGAL FIRST NAME: ");
            string first = Console.ReadLine();
            //GET USER INPUT FOR LAST NAME
            Console.WriteLine("\n\n\tYOUR LAST NAME: \n");
            string last1 = Console.ReadLine();
            //GET USER EMPLOYEE ID
            Console.WriteLine("\n\n\tENTER YOUR EMPLOYEE ID: \n");
            int Id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tFILL OUT THE FOLLOWING FOR THE SECOND RECORD: ");

            //USER INSTRUCTIONS
            Console.WriteLine("ENTER YOUR MIDDLE NAME: \n");
            string middle = Console.ReadLine();
            //GET USER INPUT FOR LAST NAME AGAIN
            Console.WriteLine("YOUR LAST NAME AGAIN: \n");
            string last2 = Console.ReadLine();
            Console.WriteLine("YOUR EMPLOYEE ID AGAIN: \n");
            int Id2 = Convert.ToInt32(Console.ReadLine());



            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee1 = new Employee();
            Employee employee2 = new Employee(); 
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' OBJECT
            employee1.FullName(FirstName: first, Full: out string Full1, LastName: last1);
            employee2.FullName(FirstName: middle, Full: out string Full2, LastName: last2);

            //CONDITION TO BE CHECKED BASED UPON EMPLOYEE ID 
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
