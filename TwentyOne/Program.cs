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
            //USER INSTRUCTIONS 
            Console.WriteLine("\tWELCOME, YOU ARE NOW ATTEMPTING TO ENTER ONLINE THE EMPLOYEE PORTAL. " +
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

            Console.WriteLine("\n\t===================================================================================" +
                "\n\n\tFOR VERIFICATION PURPOSES, PLEASE ENTER YOUR EMPLOYEE ID AGAIN: ");

            //GET USER EMPLOYEE ID 
            Console.Write("\n" +
                "\tEMPLOYEE ID: ");
            int Id2 = Convert.ToInt32(Console.ReadLine());



            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = Id1;
            employee2.Id = Id2;

            //CALL SUPERCLASS METHOD 'FullName' ON THE 'Employee' OBJECT
            employee1.employeeInfo(Id: Id1, FirstName: first, Info: out string Full1, LastName: last1);
            employee2.employeeInfo(Id: Id2, FirstName: first, Info: out string Full2, LastName: last1);

            //CONDITION TO BE CHECKED BASED UPON EMPLOYEE ID 
            if (employee1 == employee2)
            {
                Console.WriteLine("\n\tYOUR EMPLOYEE ID HAS BEEN VALIDATED!");
            }
            else
            {
                Console.WriteLine("\n\tEMPLOYEE ID: " + Id2 + " BELONGS TO A DIFFERENT EMPLOYEE" +
                    "\n\n\tPLEASE CHECK YOUR EMPLOYEE ID CAREFULLY AND TRY AGAIN.");
            }        
            Console.ReadLine();          
        }
    }
}
