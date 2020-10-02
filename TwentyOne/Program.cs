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
            //============================= STEP 248 ASSIGNMENT =============================
            Console.Write("=============================================== STEP 248 ASSIGNMENT ===============================================\n");

            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                   
                    //USER INSTRUCTIONS 
                    Console.WriteLine("\n====================================================== START ======================================================\n");

                    //INSTANTIATE 'employee1' OBJECT WITH DATA TYPE <string> AS ITS PARAMETER (FROM THE GENERIC DATA TYPE GIVEN TO THE LIST PROPERTY 'things' IN THE CLASS)
                    Employee<string> employee1 = new Employee<string>();
                    employee1.Things = new List<string>();

                  
                    //ASSIGN A LIST OF STRINGS ONE-BY-ONE TO THE EMPLOYEE OBJECT 'employee1' AS THE PROPERTY VALUE OF THINGS USING THE 'Add' METHOD
                    employee1.Things.Add("WELCOME PACKET");
                    employee1.Things.Add("BENEFITS PACKET");
                    employee1.Things.Add("ID BADGE");
                    employee1.Things.Add("NAME TAG");
                    employee1.Things.Add("LAPTOP");

                    //OUTPUT INFORMATION ABOUT OBJECT 'employee1'
                    Console.WriteLine("\tTHIS DISPLAYS THE LIST OF STRINGS FROM AN OBJECT CREATED FROM THE GENERIC-PARAMETERED CLASS \'Employee<T>\'\n");

                    foreach (string item in employee1.Things)
                    {
                        Console.WriteLine("\t\t- " + item + "\n");
                    }

                    Console.WriteLine("===================================================================================================================\n");

                    //INSTANTIATE 'employeeID_List' OBJECT WITH DATA TYPE <int> AS ITS PARAMETER...
                    Employee<int> companyID_List = new Employee<int>();
                    companyID_List.Things = new List<int> { 100, 101, 102, 103, 104, 105, 106, 107 };

                    Console.WriteLine("\tCOMPANY EMPLOYEE ID'S (INTEGERS) STORED IN ANOTHER OBJECT FROM THE GENERIC-PARAMETERED CLASS \'Employee<T>\'\n");

                    foreach (int ID in companyID_List.Things)
                    {
                        Console.WriteLine("\t\t- " + ID + "\n");
                    }

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
                    Console.Write("================================================== END TRY/CATCH ==================================================\n" +
                        "\n\t                 ---- (PRESS ENTER TO RUN AGAIN) ----\n\n" +
                        "\t\t\t\t            OR\n\n" +
                        "\t\t        XXX (PRESS \'X\' TO EXIT THE PROGRAM) XX");

                    string exit = Console.ReadLine();
                    Console.WriteLine("\n===================================================================================================================");
                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
                    if ((exit == "x") || (exit == "X"))
                    {
                        executing = false;
                    }
                }
            }
            while (executing);

            //EXIT PROGRAM INFO
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 248 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}