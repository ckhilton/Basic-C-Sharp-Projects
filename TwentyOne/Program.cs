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
            //============================= STEP 224 ASSIGNMENT =============================
            Console.Write("===================================== STEP 224 ASSIGNMENT ==========================================\n" +
                "\n\n\tYOU JUST CAME ACROSS A GIANT BOX OF SHOES IN YOUR WIFE'S CLOSET." +
                "\n\n\tAFTER YOU COUNT THEM, YOU GET A TOTAL OF...\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //TRY-CATCH: THE CODE I WANT TO WORK
                try
                {
                    //INSTANTIATE CLASS OBJECT CALLED 'box'
                    Pairs box = new Pairs();

                    //GET USER INPUT
                    Console.Write("\n=========================================== START ===================================================\n" +
                        "\n\tTOTAL SHOE COUNT: ");
                    //GET USER INPUT 
                    int totalShoes = Convert.ToInt32(Console.ReadLine());                                    
                    //USE METHOD ON 'wedding' OBJECT AND PASS IN THE THE NUMBER OF SHOES THE USER FOUND
                    box.Shoes(total: totalShoes, out int pairs); 
                    
                    //DISPLAY THE NUMBER OF SHOES DIVIDED BY 2 TO GET THE NUMBER OF PAIRS THAT SHOULD BE MATCHING
                    Console.WriteLine("\n\tWITH A TOTAL OF " + totalShoes + " SHOES IN THE BOX, YOU SHOULD HOPE TO FIND AT LEAST:" +
                        "\n\n\t\t- " + pairs + " MATCHING PAIRS OF SHOES. :)\n");                    
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
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 224 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}