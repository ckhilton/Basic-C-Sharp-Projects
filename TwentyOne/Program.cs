using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) //***NOTE: AN ACCESS MODIFIER EXAMPLE IS 'public', WHICH WOULD GIVE ACCESS TO THE FUNCTION FROM THE REST OF THE PROGRAM
        {
            //============================= STEP 240 ASSIGNMENT =============================
            Console.Write("===================================== STEP 240 ASSIGNMENT ==========================================\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    Console.WriteLine("\n======================================== START ========================================");
                    //CREATE NEW EMPTY LIST CALLED 'names' FROM THE INHERITED PROPERTIES OF 'Person'
                    List<Person> newlyHired = new List<Person>();
                    //CREATE A NEW EMPLOYEE TO ADD TO THE LIST
                    Employee name = new Employee();

                    //DISPLAY COMPANY WELCOME INFO
                    Console.WriteLine("\nWELCOME TO THE COMPANY, LETS START WITH SOME BASIC PAPERWORK...");

                    //USER INSTRUCTIONS
                    Console.Write("\n" +
                        "\tPLEASE ENTER YOUR FIRST NAME: ");
                    //GET WEEKLY HOURS WORKED AS AN INTEGER                    
                    string inputFirst = Console.ReadLine();

                    //USER INSTRUCTIONS
                    Console.Write("\n" +
                        "\tPLEASE ENTER YOUR LAST NAME: ");
                    //GET WEEKLY HOURS WORKED AS AN INTEGER                    
                    string inputLast = Console.ReadLine();
                    
                    //CALL ABSTRACT METHOD ON THE 'name' OBJECT
                    name.FullName(FirstName: inputFirst.ToUpper(), out string Full, LastName: inputLast.ToUpper());
                    //ADD NAME TO THE 'List<Person>' OF 'newlyHired' (USE POLYMORPHISM)
                    newlyHired.Add(name);

                    //DISPLAY INFO TO USER
                    Console.WriteLine("\n\tYOUR NAME WILL APPEAR ON COMPANY RECORDS AS FOLLOWS..." +
                        "\n\n\t\tFULL NAME: " + Full +
                        "\n\n\t(PRESS ENTER)");
                    Console.ReadLine();

                    Console.WriteLine("\tIT TURNS OUT THE COMPANY YOU JUST JOINED UP WITH IS DOING SHADY BUSINESS! " +
                        "\n\n\tPRESS ENTER TO QUIT THE JOB IMMEDIATELY!");
                    Console.ReadLine();

                    //CALL INTERFACE 'Quit()' FUNCTION AND DISPLAY OUTPUT
                    name.Quit(name);
                }

                //================ EXCEPTION HANDLING ================              
                //WRONG FORMAT CATCH
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\tTISK TISK, WRONG FORMAT!!! " +
                        "\n\n\t   - TEXT NOT ALLOWED. " +
                        "\n\n\t   - WHOLE NUMBERS ONLY. " +
                        "\n\n\t   - NULL IS NOT ACCEPTABLE EITHER." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                }
                //GENERAL CATCH IF TOO LARGE OF OR TOO SMALL OF AN INTEGER WERE ENTERED
                catch (Exception ex)
                {
                    Console.WriteLine("\n\tEASY DOES IT THERE!!!" +
                        "\n\n\t   - YOUR " + ex.Message.ToUpper() +
                        "\n\n\t   - NOT TOO BIG." +
                        "\n\n\t   - NOT TOO NEGATIVE." +
                        "\n\n\t   - NICE AND EASY." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                }
                //INSTRUCTIONS TO USER
                finally
                {
                    //PROGRAM NOTE   
                    Console.Write("======================================= END TRY/CATCH ===============================================\n" +
                        "\n\t                 ---- (PRESS ENTER TO RUN AGAIN) ----\n\n" +
                        "\t\t\t\t            OR\n\n" +
                        "\t\t        XXX (PRESS \'X\' TO EXIT THE PROGRAM) XX");

                    string exit = Console.ReadLine();
                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
                    if ((exit == "x") || (exit == "X"))
                    {
                        executing = false;
                    }
                }
            }
            while (executing);

            //DISCLAIMER AND REFERENCES FOR USER
            Console.WriteLine("\n=====================================================================================================");
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 240 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}