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
            //============================= STEP 245 ASSIGNMENT =============================
            Console.Write("===================================== STEP 245 ASSIGNMENT =====================================\n");

            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                   
                    //USER INSTRUCTIONS 
                    Console.WriteLine("\n\tWELCOME, YOU ARE NOW ATTEMPTING TO ENTER THE ONLINE EMPLOYEE PORTAL. " +
                        "\n\n============================================ START ============================================" +
                        "\n\n\tPLEASE FILL OUT THE FOLLOWING:");
                    //GET USER INPUT FOR FIRST NAME 
                    Console.Write("\n" +
                        "\tFIRST NAME: ");
                    string first = Console.ReadLine();

                    ////GET USER INPUT FOR LAST NAME
                    Console.Write("\n" +
                        "\tLAST NAME: ");
                    string last1 = Console.ReadLine();

                    //GET USER EMPLOYEE ID
                    Console.Write("\n" +
                        "\tEMPLOYEE ID: ");
                    int Id1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n\t=======================================================================================" +
                        "\n\n\tFOR VERIFICATION PURPOSES, PLEASE ENTER YOUR EMPLOYEE ID AGAIN: ");

                    //VERIFY USER EMPLOYEE ID 
                    Console.Write("\n" +
                        "\tEMPLOYEE ID: ");
                    int Id2 = Convert.ToInt32(Console.ReadLine());

                    //INSTANTIATE AND INITIATE 'Employee' OBJECTS
                    Employee employee1 = new Employee();
                    Employee employee2 = new Employee();

                    employee1.Id = Id1;
                    employee2.Id = Id2;

                    //CALL SUPERCLASS METHOD 'FullName' ON THE 'Employee' OBJECTS
                    employee1.employeeInfo(Id: Id1, FirstName: first, Info: out string Full1, LastName: last1);
                    employee2.employeeInfo(Id: Id2, FirstName: first, Info: out string Full2, LastName: last1);

                    //CONDITION TO BE CHECKED BASED UPON EMPLOYEE ID 
                    if (employee1 != employee2)
                    {
                        Console.WriteLine("\n\tEMPLOYEE ID: " + Id2 + " DID NOT MATCH!" +
                            "\n\n\tPLEASE CHECK YOUR EMPLOYEE ID CAREFULLY AND TRY AGAIN\n");
                    }
                    else
                    {         
                        Console.WriteLine("\n\tYOUR EMPLOYEE ID HAS BEEN VALIDATED!\n");
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
                    Console.Write("======================================== END TRY/CATCH ========================================\n" +
                        "\n\t                 ---- (PRESS ENTER TO RUN AGAIN) ----\n\n" +
                        "\t\t\t\t            OR\n\n" +
                        "\t\t        XXX (PRESS \'X\' TO EXIT THE PROGRAM) XX");

                    string exit = Console.ReadLine();
                    Console.WriteLine("\n===============================================================================================");
                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
                    if ((exit == "x") || (exit == "X"))
                    {
                        executing = false;
                    }
                }
            }
            while (executing);

            //EXIT PROGRAM INFO
            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 245 ASSIGNMENT\" PROGRAM" +
                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}