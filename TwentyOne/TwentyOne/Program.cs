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
            Console.Write("\n===================================== STEP 216 ASSIGNMENT ===========================================\n" +
                "\n  THIS CONSOLE APP WILL APPROXIMATE YOUR ANNUAL SALARY INFO BASED ON A 40 HR WORK WEEK\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    Console.Write("\n=========================================== START ===================================================\n" +                       
                        "\n\tENTER AN HOURLY WAGE: ");
                    //Console.WriteLine("\n\tENTER AN HOURLY WAGE: ");
                    //GET USER INPUT
                    int hourly = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\t----------------------------------------------------");
                    //GIVE USER INSTRUCTIONS
                    Console.WriteLine("\n\tBASED ON AN HOURLY WAGE OF " + String.Format("{0:C}", hourly) + " PER HOUR ..." +
                        "\n\n\tYOUR ANNUAL SALARY INFORMATION IS AS FOLLOWS ...");
                    //CALL EACH FUNCTION
                    int gross = Salary.Gross(hourly);
                    Console.WriteLine("\n\t  - GROSS ANNUAL INCOME:\t" + String.Format("{0:C}", gross));

                    int tax = Salary.Tax(gross);
                    Console.WriteLine("\n\t  - AVERAGE TOTAL TAX:\t\t" + String.Format("{0:C}", tax) + " ***");

                    int net = Salary.Net(gross);
                    Console.WriteLine("\n\t  - RAW NET ANNUAL INCOME:\t" + String.Format("{0:C}", net));

                    //ADDITIONAL INFO FOR USER
                    Console.WriteLine("\n\tHERE IS SOME ADDITIONAL HELPFUL INFORMATION ..." +
                        "\n\n\t\t(PRESS ENTER)");
                    Console.ReadLine();

                    //CALL TITHING/CHARITY FUNCTIONS
                    int titheGross = Salary.Tithe_Gross(gross);
                    int titheNet = Salary.Tithe_Net(net);
                    int netTitheGross = Salary.Net_Tithe_Gross(net, titheGross);
                    int netTitheNet = Salary.Net_Tithe_Net(net, titheNet);

                    //DISPLAY INFORMATION/OUTPUT
                    Console.WriteLine("\tA GENEROUS RELIGIOUS TITHE OR CHARITY DONATION OF 10% ..." +
                        "\n\n\t  - ON YOUR GROSS INCOME IS:\t" + String.Format("{0:C}", titheGross) +
                        "\n\n\t  - ON YOUR NET INCOME IS:\t" + String.Format("{0:C}", titheNet) +
                        "\n\n\t\t(PRESS ENTER)");
                    Console.ReadLine();

                    Console.WriteLine("\t----------------------------------------------------------------------" +
                        "\n\n\tHERE ARE YOUR NET ANNUAL INCOME VARIANCE TOTALS: " +                       
                        "\n\n\tAFTER TAXES AND 10% TITHE OF GROSS:\t( NET TOTAL ) " + String.Format("{0:C}", netTitheGross) +
                        "\n\n\tAFTER TAXES AND 10% TITHE OF NET:\t( NET TOTAL ) " + String.Format("{0:C}", netTitheNet) +
                        "\n\n\tAFTER TAXES WITHOUT ANY DONATIONS:\t( NET TOTAL ) " + String.Format("{0:C}", net) +
                        "\n\n\t*********************************************************************************" +
                        "\n\tDISCLAIMER: THIS APP DOES NOT TAKE TAX BREAKS INTO CONSIDERATION. BUT YOU SHOULD!" +
                        "\n\t*********************************************************************************" +                                  
                        "\n\n\t(PRESS ENTER)");
                    Console.ReadLine();
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
                        "\n\t             ---- (PRESS ENTER TO TRY ANOTHER HOURLY WAGE) ----\n\n" +
                        "\t\t\t\t            OR\n\n" +
                        "\t\t        XXX (PRESS \'X\' TO SEE REFERENCE/SOURCE) XX");
                        
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

            Console.WriteLine("\nREFERENCE: " +
                "\n\n*** THE AVERAGE SINGLE AMERICAN GAVE 29.6% TO 3 TAXES IN 2018: INCOME, MEDICARE, AND SOCIAL SECURITY.\n" +
                "\nSOURCE: " +
                "\n\nhttps://www.thebalance.com/what-the-average-american-pays-in-taxes-4768594#:~:text=The%20average%20income%20tax%20rate,one%20study%20of%20BLS%20numbers.");
            Console.WriteLine("\n(PRESS ENTER TO CLOSE WINDOW)\n");
            Console.ReadKey(true);
        }
    }        
}
