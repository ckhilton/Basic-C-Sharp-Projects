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
                "\n\n\tYOU JUST CAME ACROSS A GIANT BOX OF SHOES IN YOUR SPOUSE' CLOSET." +
                "\n\n\tAFTER YOU DUMP THEM ALL OUT ON THE FLOOR, YOU FIND...\n");
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

                    //USER INSTRUCTIONS
                    Console.Write("\n=========================================== START ===================================================\n" +
                        "\n\tTOTAL NUMBER OF INDVIDUAL SHOES? ");
                    //GET USER INPUT 
                    int totalShoes = Convert.ToInt32(Console.ReadLine());

                    //USER INSTRUCTIONS
                    Console.Write("\n" +
                        "\tTHE MOST POPULAR BRAND? ");
                    //GET USER INPUT 
                    string brand = Console.ReadLine();

                    //USER INSTRUCTIONS
                    Console.Write("\n" +
                        "\tTHE MOST FREQUENTLY FOUND SIZE? ");
                    //GET USER INPUT 
                    float size = float.Parse(Console.ReadLine());

                    //USE METHOD ON 'box' OBJECT AND PASS IN THE THE NUMBER OF SHOES THE USER FOUND
                    box.Shoes(total: totalShoes, out int pairs, size: size, brand: brand);

                    //USER INSTRUCTIONS                                   
                    Console.WriteLine("\n\t(PRESS ENTER)");                       
                    Console.ReadLine();
                    Console.WriteLine("\n=====================================================================================================\n");

                    //DISPLAY OUTPUT TO USER
                    Console.WriteLine("\n\tWITH A TOTAL OF " + totalShoes + " SHOES IN THE BOX, YOU SHOULD HOPE TO FIND AT LEAST:" +
                        "\n\n\t\t- " + pairs + " MATCHING PAIRS OF SHOES.\n" +
                        "\n\tTHE NEXT SHOES YOUR SPOUSE WILL MOST LIKELY BUY WILL BE A PAIR OF:" +
                        "\n\n\t\t- SIZE " + size + " " + brand.ToUpper() + "\'S.\n");

                    //USER INSTRUCTIONS
                    Console.WriteLine("\t\t(PRESS ENTER)");
                    Console.ReadLine();

                    //USER INSTRUCTIONS
                    Console.Write("\n========================================== PART 2 ===================================================\n" +
                        "\n\tSITUATION: YOU AND YOUR SIBLING DECIDE THAT YOU WILL START SHARING A PHONE PLAN TO SAVE MONEY...\n");
                    //GET USER INPUT FOR TOTAL MONTHLY BILL
                    Console.Write("\n=====================================================================================================\n" +
                        "\n\tHOW MUCH IS THE TOTAL BILL PER MONTH? $");                   
                    float total = float.Parse(Console.ReadLine());

                    //CALL FUNCTION FROM STATIC CLASS 'Phones'
                    Phones.Bill(total: total, out float each, out float yearly);

                    //OUTPUT
                    Console.Write("\n\tEACH PERSON WILL PAY:" +
                        "\n\n\t\t" + string.Format("{0:C}", each ) + " PER MONTH" +
                        "\n\n\t\t" + string.Format("{0:C}", yearly) + " PER YEAR\n\n");
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