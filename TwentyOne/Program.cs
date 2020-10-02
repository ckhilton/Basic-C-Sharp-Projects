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
            //============================= STEP 254 ASSIGNMENT =============================
            Console.Write("===================================== STEP 254 ASSIGNMENT =====================================\n");

            //LOOP CONTROL VARIABLE
            bool run = true;
            do
            {
                try
                {
                    //USER INSTRUCTIONS 
                    Console.Write("\n============================================ START ============================================" +
                        "\n\n\tPLEASE ENTER THE CURRENT DAY OF THE WEEK: ");

                    //ESTABLISH ACTUAL DAY OF WEEK
                    DayOfWeek weekday = DateTime.Today.DayOfWeek;
                    
                    //GET USER INPUT 
                    string input = Console.ReadLine();

                    //PARSE THROUGH THE ENUM 'Day' IN SEARCH OF MATCHING USER INPUT
                    Day today = (Day)Enum.Parse(typeof(Day), input.ToUpper());

                    //CONDITIONS
                    // 1) IF THE INPUT IS VALID AND TODAY IS FRIDAY...
                    if (input.ToUpper() == "FRIDAY")
                    {
                        // DISPLAY THE FOLLOWING
                        Console.WriteLine("\n\tFRIDAY!!! ************ T.G.I.F. ************ FRIDAY!!!");
                    }
                    // 2) IF THE INPUT IS VALID BUT NOT THE CORRECT DAY OF THE WEEK
                    else if (input.ToUpper() != weekday.ToString().ToUpper())
                    {
                        // SHOW USER IT'S NOT THE CORRECT DAY OF THE WEEK
                        Console.WriteLine("\n\tTODAY IS NOT " + input.ToUpper());
                    }
                    // 3) IF IT'S NOT FRIDAY AND THE INPUT IS A VALID ENUM PARAMETER
                    else
                    {
                        // DISPLAY THE FACT ABOUT TODAY
                        Console.WriteLine("\n\tTODAY IS: " + input.ToUpper());
                    }
                }

                // EXCEPTION HANDLING
                // THE INPUT DOES NOT MATCH ANY VALUES INSIDE THE DATA TYPE 'Day'
                catch (Exception ex)
                {
                    //NOTIFY USER OF THE EXCEPTION
                    Console.WriteLine("\n\t***PLEASE ENTER AN ACTUAL DAY OF THE WEEK***");
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
                        run = false;
                        Console.WriteLine("\n=====================================================================================================");
                    }
                }
            }
            while (run);

            //EXIT PROGRAM INFO
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 254 ASSIGNMENT\" PROGRAM!" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}