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
            Console.WriteLine("\n=============================== STEP 240 ===============================");
            //CREATE NEW EMPTY LIST CALLED 'names' FROM THE INHERITED PROPERTIES OF 'Person'
            List<Person> newlyHired = new List<Person>();
            //CREATE A NEW EMPLOYEE TO ADD TO THE LIST
            Employee name = new Employee();
            
            //DISPLAY COMPANY WELCOME INFO
            Console.WriteLine("\nWELCOME TO THE COMPANY, LETS START WITH SOME BASIC PAPERWORK...");

            //USER INSTRUCTIONS
            Console.Write("\n" +
                "\tPLEASE ENTER YOUR FIRST NAME: ");
            //GET WEEKLY HOURS WORKED AS AN INTEGER                    
            string inputFirst = Console.ReadLine();

            //USER INSTRUCTIONS
            Console.Write("\n" +
                "\tPLEASE ENTER YOUR LAST NAME: ");
            //GET WEEKLY HOURS WORKED AS AN INTEGER                    
            string inputLast = Console.ReadLine();

            //CALL ABSTRACT METHOD ON THE 'name' OBJECT
            name.FullName(FirstName: inputFirst.ToUpper(), out string Full, LastName: inputLast.ToUpper());
            //ADD NAME TO THE 'List<Person>' OF 'newlyHired' (USE POLYMORPHISM)
            newlyHired.Add(name);

            //DISPLAY INFO TO USER
            Console.WriteLine("\n\tYOUR NAME WILL APPEAR ON COMPANY RECORDS AS FOLLOWS..." +
                "\n\n\t\tFULL NAME: " + Full +
                "\n\n\t(PRESS ENTER)");
            Console.ReadLine();

            Console.WriteLine("\tIT TURNS OUT THE COMPANY YOU JUST JOINED UP WITH IS DOING SHADY BUSINESS! " +
                "\n\n\tPRESS ENTER TO QUIT THE JOB IMMEDIATELY!");
            Console.ReadLine();

            //CALL INTERFACE 'Quit()' FUNCTION AND DISPLAY OUTPUT
            name.Quit(name);
            
            
            Console.ReadLine();          
        }
    }
}