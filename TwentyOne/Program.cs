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
            bool run = true;
            
            //CONSTANT KEYWORD VARIABLE EXAMPLE (THE NAME WILL NEVER CHANGE THROUGHOUT THE PROGRAM)
            const string company = "HILTON CONSULTING CORPORATION";
            Console.WriteLine("WELCOME TO THE {0} EMPLOYEE PORTAL." +
                "\n\nTHIS IS YOUR FIRST TIME ACCESSING THE SYSTEM, LET'S GET YOU SET UP!" +
                "\n\nPLEASE ENTER THE FOLLOWING INFORMATION:", company);
            do
            {
                //STORE USER INFO/INPUT IN VARIABLES USING 'var' KEYWORD
                Console.Write("\nA UNIQUE 4-DIGIT ONLINE ACCESS ID HERE (DON'T FORGET): ");
                var access = Convert.ToInt32(Console.ReadLine());

                Console.Write("FIRST NAME: ");
                var first = Console.ReadLine().ToUpper();

                Console.Write("LAST NAME: ");
                var last = Console.ReadLine().ToUpper();

                Console.Write("YOUR DOB: ");
                var dob = Console.ReadLine().ToUpper();

                //USE CHAINED 'Employee' CONSTRUCTORS THAT DISPLAY A DEFAULT A MESSAGE ABOUT THE EMPLOYEES DEPARTMENT NAME
                var employee = new Employee(access, first, last, dob);
                List<string> all = employee.Full;
                
                Console.Write("\nWE WILL NOW PROCEED TO VERIFY AND STORE YOUR INFORMATION." +
                    "\n\nTHIS INFORMATION IS KEPT PRIVATE IN OUR EMPLOYEE RECORDS." +
                    "\n\n\tTYPE \"Y\" IF YOU UNDERSTAND AND AGREE TO CONTINUE." +
                    "\n\tTYPE \"N\" IF YOU WISH TO STOP AND EXIT THE PROGRAM." +
                    "\n\n\tANSWER: (\"Y\" OR \"N\") ");
                string answer = Console.ReadLine().ToUpper();               

                //CONTROL CONDITIONS FOR VERIFYING INFO
                bool display = (answer == "Y");
                if (display)
                {
                    //CALL 'Verify' METHOD
                    employee.Verify();
                    //INSTANTIATE NEW GUID (GLOBAL UNIQUE IDENTIFIER) WITH THE 'Player' PROPERTY OF 'ID'
                    employee.EmpID = Guid.NewGuid();
                    //LOG THE USERS NAME 
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Basic_C#_Programs - Copy\TwentyOne\TwentyOne\EmployeeLog.txt", true)) //'true' APPENDS THE LIST, RATHER THAN OVERWRITING IT EACH TIME.
                    {
                        file.Write("EMPLOYEE ID: {0}", employee.EmpID);
                        //LOG ALL VALUES IN THE LIST PROPERTY 'Full' THAT ARE IN THE 'Employee' CLASS OBJECT 'employee' AND                       
                        file.WriteLine("\nONLINE ACCESS ID: {0}" +
                            "\nLAST NAME: {1}" +
                            "\nFIRST NAME: {2}" +
                            "\nDOB: {3}" +
                            "\nDEPARTMENT: {4}", all.ElementAt(0), all.ElementAt(2), all.ElementAt(1), all.ElementAt(3), all.ElementAt(4));       
                    }                    
                    Console.WriteLine("\nYOUR ONLINE EMPLOYEE SETUP IS COMPLETE!!!");
                    break;
                }
                if (!display && answer != "N")
                {
                    break;
                }
                if (!display)
                {
                    run = true;
                }
            }
            //DO-WHILE LOOP RUNS IF USER ANSWERS 'N' AND NEEDS TO CHANGE INFO 
            while (run);
            Console.ReadLine();
        }
    }
}