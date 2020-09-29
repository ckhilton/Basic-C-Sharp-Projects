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
            Console.Write("===================================== STEP 224 ASSIGNMENT ==========================================\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    //INSTANTIATE CLASS OBJECT CALLED 'salary'
                    Invitations wedding = new Invitations();

                    //USER INSTRUCTIONS
                    Console.WriteLine("\n============================================ START =================================================\n" +
                        "\n\tENTER IN THE NUMBER OF COUPLES INVITED TO THE WEDDING: ");
                    //GET USER INPUT
                    int inputCouples = Convert.ToInt32(Console.ReadLine());                   
                    //CALL METHOD/FUNCTION BY NAME AND PASS IN SAME 2 NUMBERS (INTEGERS)
                    wedding.Invites(inputCouples, out int invites); 
                    
                    //DISPLAY THE NUMBER OF COUPLES DIVIDED BY 2 TO GET THE TOTAL INVITATIONS TO SEND OUT
                    Console.WriteLine("WITH A TOTAL OF " + inputCouples + " COUPLES ON YOUR LIST, YOU'LL NEED:" +
                        "\n\n\t\t" + invites + " TOTAL INVITATIONS");
                    
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