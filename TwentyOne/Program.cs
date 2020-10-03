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
            //LOOP CONTROL VARIABLE...
            bool again = true;

            do 
            {
                try
                {
                    //============================= STEP 260 ASSIGNMENT =============================
                    Console.Write("\n===================================== STEP 260 ASSIGNMENT =====================================\n");
                    //CREATE NEW OBJECT
                    Number myAccount = new Number();
                    //ASSIGN AMOUNT TO NEW OBJECT 'myAccount'
                    myAccount.Amount = 0.00F;
                    //DISPLAY OUTPUT
                    Console.WriteLine("\n\tMY CURRENT BANK ACCOUNT BALANCE: " + String.Format("{0:C}", myAccount.Amount));

                    //USER INSTRUCTIONS
                    Console.WriteLine("\n\n\tNOW ENTER YOUR")
                }

                // EXCEPTION HANDLING
                catch (Exception ex)
                {
                    //NOTIFY USER OF THE EXCEPTION
                    Console.WriteLine("\n\t" + ex.Message.ToUpper());
                }
                finally
                {
                    Console.Write("\n======================================= END TRY / CATCH =======================================" +
                        "\n\n\tPRESS ENTER TO RUN THE PROGRAM AGAIN" +
                        "\n\n\t\t\t OR" +
                        "\n\n\tPRESS 'X' TO EXIT THE PROGRAM: ");
                    string stop = Console.ReadLine();
                    if (stop.ToUpper() == "X")
                    {
                        again = false;
                        Console.WriteLine("\n=====================================================================================================");
                    }
                }
            }
            while (again);

            //EXIT PROGRAM INFO
            Console.WriteLine("\n\t\'SHORT-\'N-SWEET\' IS HOW WE LIKE IT!" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }     
    }
}