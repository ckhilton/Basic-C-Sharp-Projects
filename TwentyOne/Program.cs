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
            //============================= STEP 216 ASSIGNMENT =============================
            Console.Write("\n===================================== STEP 219 ASSIGNMENT ===========================================\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    //GET USER INPUT
                    Console.Write("\n=========================================== START ===================================================\n" +
                        "\n\tENTER YOUR HOURLY WAGE (AS A DECIMAL): $");
                    //GET USER INPUT AS A DECIMAL
                    int hourly = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n=========================================== NEXT ===================================================\n" +
                        "\n\tENTER YOUR AVERAGE NUMBER OF WEEKLY WORK HOURS: ");
                    //GET USER INPUT
                    int hours = Convert.ToInt32(Console.ReadLine());
                    //CALL FUNCTION
                    int gross = Salary.Gross(hourly, out hours);
                    //OUTPUT/USER INFO FOR ANNUAL AVERAGE
                    Console.WriteLine("\n\t----------------------------------------------------");
                    Console.WriteLine("\n\tBASED ON WORKING " + hours + " HOURS PER WEEK... " +
                        "\n\n\t\t  - ANNUAL INCOME IS: " + gross + " (APPROXIMATELY)\n");
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
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 219 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}