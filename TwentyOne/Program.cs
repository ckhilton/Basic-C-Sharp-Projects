using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            //DO-WHILE CONTROL
            bool run = true;
            
            //CONSTANT KEYWORD VARIABLE EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
            const string company = "HILTON CONSULTING CORPORATION";
            Console.WriteLine("WELCOME TO THE {0} EMPLOYEE PORTAL." +
                "\n\nTHIS IS YOUR FIRST TIME ACCESSING THE SYSTEM, LET'S GET YOU SET UP!", company);            
                
            do
            {
                //STORE USER INFO/INPUT IN VARIABLES USING 'var' KEYWORD
                Console.Write("\nPLEASE ENTER THE FOLLOWING INFORMATION: " +
                    "\n\nA UNIQUE 4-DIGIT ONLINE ACCESS ID HERE (DON'T FORGET): ");
                var access = Convert.ToInt32(Console.ReadLine());

                Console.Write("FIRST NAME: ");
                var first = Console.ReadLine().ToUpper();

                Console.Write("LAST NAME: ");
                var last = Console.ReadLine().ToUpper();

                Console.Write("YOUR DOB: ");
                var dob = Console.ReadLine().ToUpper();

                //USE CHAINED 'Employee' CONSTRUCTORS. THIS WILL DISPLAY A DEFAULT MESSAGE FOR THE CHAINED 'Employee' CONSTRUCTOR WITH THE PARAMETER 'department' 
                var employee = new Employee(access, first, last, dob);                
                
                Console.Write("\nWE WILL NOW PROCEED TO VERIFY AND STORE YOUR INFORMATION." +
                    "\n\nTHIS INFORMATION IS KEPT PRIVATE IN OUR EMPLOYEE RECORDS." +
                    "\n\n\tTYPE \"Y\" IF YOU UNDERSTAND AND AGREE TO CONTINUE." +
                    "\n\tTYPE \"N\" IF YOU WISH TO MAKE EDITS TO YOUR INFO." +
                    "\n\tTYPE \"X\" IF YOU WISH TO EXIT THE PROGRAM." +
                    "\n\n\tOPTIONS: (Y/N OR X) ");
                string answer = Console.ReadLine().ToUpper();               

                //CONTROL CONDITIONS FOR VERIFYING INFO
                bool display = (answer == "Y");
                if (display)
                {
                    //IF 'Verify' METHOD RETURNS 'true' THE DO-WHILE LOOP ENDS AND THE PROGRAM STOPS
                    if (employee.Verify() == true)
                    {
                        run = false;
                    }
                }
                if (answer == "N")
                {                  
                    run = true;
                }

                if (answer == "X")
                {
                    Console.WriteLine("\n(PRESS \"ENTER\" TO CLOSE THE WINDOW)");
                    run = false;
                }
            }
            //DO-WHILE LOOP RUNS IF USER ANSWERS 'N' AND NEEDS TO CHANGE INFO 
            while (run);
            Console.ReadLine();
        }
    }
}