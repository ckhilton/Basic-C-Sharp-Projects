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
            //Console.Write("\n" +
            //    "\tYOUR LEGAL FIRST NAME: ");                             
            //string first = Console.ReadLine();

            ////GET USER INPUT FOR LAST NAME
            //Console.Write("\n" +
            //    "\tYOUR LEGAL LAST NAME: ");
            //string last1 = Console.ReadLine();

            //GET USER EMPLOYEE ID
            Console.Write("\n" +
                "\tYOUR EMPLOYEE ID: ");
            int Id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\t===================================================================================" +
                "\n\n\tFILL OUT THE FOLLOWING TO CHECK THE SECOND RECORD: ");

            ////GET USER INPUT FOR FIRST NAME 
            //Console.Write("\n" +
            //    "\tYOUR MIDDLE NAME: ");
            //string goesBy = Console.ReadLine();

            ////GET USER INPUT FOR LAST NAME AGAIN 
            //Console.Write("\n" +
            //    "\tYOUR LAST NAME AGAIN: ");
            //string last2 = Console.ReadLine();

            //GET USER EMPLOYEE ID 
            Console.Write("\n" +
                "\tYOUR EMPLOYEE ID AGAIN (IF GIVEN 2 DIFFERENT ID'S, PLEASE ENTER THE SECOND): ");
            int Id2 = Convert.ToInt32(Console.ReadLine());



            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee1 = new Employee();
            Employee employee2 = new Employee(); 
            //CALL SUPERCLASS METHOD 'FullName' ON THE 'Employee' OBJECT
            //employee1.employeeInfo(Id: Id1, FirstName: first, Info: out string Full1, LastName: last1);
            //employee2.employeeInfo(Id: Id2, FirstName: goesBy, Info: out string Full2, LastName: last2);

            //CONDITION TO BE CHECKED BASED UPON EMPLOYEE ID 
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("\n\t" + /*Full1 +*/ 
                    "\n\n\tIS THE SAME EMPLOYEE AS " +
                    "\n\n\t" /*+ Full2*/);
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
