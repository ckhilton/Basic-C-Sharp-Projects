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
            Console.Write("===================================== STEP 221 ASSIGNMENT ==========================================\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    //INSTANTIATE CLASS OBJECT CALLED 'salary'
                    Salary salary = new Salary();

                    //CALL METHOD/FUNCTION AND PASS IN 2 NUMBERS (INTEGERS)
                    Console.WriteLine("\n============================================ START =================================================\n" +
                        "\n\t(BELOW I MANUALLY PASS IN 'daily' HOURS AND HOURLY 'wage' AS (8, 30)...PRESS ENTER)" + Console.ReadLine());
                    salary.Gross(8, 30);
                    
                    //USER INSTRUCTIONS
                    Console.Write("============================================= NEXT =================================================\n" +
                        "\n\t(THIS TIME I WILL GET USER INPUT, PASS IT IN, AND SPECIFY THE PARAMETERS BY NAME...)\n" +
                        "\n\tENTER THE NUMBER OF HOURS YOU WORKED TODAY: ");
                    //GET DAILY HOURS WORKED AS AN INTEGER
                    int dailyInput = Convert.ToInt32(Console.ReadLine());
                    //USER INSTRUCTIONS
                    Console.Write("\n" +
                        "\tENTER YOUR HOURLY WAGE: ");
                    //GET WEEKLY HOURS WORKED AS AN INTEGER                    
                    int hourly = Convert.ToInt32(Console.ReadLine());                   
                    
                    //CALL METHOD/FUNCTION BY NAME AND PASS IN SAME 2 NUMBERS (INTEGERS)
                    salary.Gross(daily: dailyInput, wage: hourly);     
                    
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
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 221 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}