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

            //CREATE NEW EMPTY 'List<Employee>' CALLED 'all'
            List<Employee> all = new List<Employee>();

            //ADD 10 EMPLOYEES, 2 OF WHICH HAVE THE FIRST NAME "Joe"
            all.Add(new Employee(ID: 100, firstName: "Joe", lastName: "Gibbs"));
            all.Add(new Employee(ID: 101, firstName: "Steve", lastName: "Hilton"));
            all.Add(new Employee(ID: 102, firstName: "Heidi", lastName: "Hilton"));
            all.Add(new Employee(ID: 103, firstName: "Vince", lastName: "Hilton"));
            all.Add(new Employee(ID: 104, firstName: "Drew", lastName: "Hilton"));
            all.Add(new Employee(ID: 105, firstName: "Kirk", lastName: "Hilton"));
            all.Add(new Employee(ID: 106, firstName: "Rob", lastName: "Hilton"));
            all.Add(new Employee(ID: 107, firstName: "Joe", lastName: "Montana"));
            all.Add(new Employee(ID: 108, firstName: "Dave", lastName: "Hilton"));
            all.Add(new Employee(ID: 109, firstName: "Jeff", lastName: "Hilton"));

            //CREATE NEW EMPTY 'List<Employee>' CALLED 'joes'
            List<Employee> joes = new List<Employee>();

            //OUTPUT FORMATTING
            Console.WriteLine("\n\tTHIS DISPLAYS THE FULL NAME OF EACH PERSON IN THE LIST NAMED \"Joe\"\n");

            //CONDITION TO ITERATE THROUGH 'List<Employee> all' 
            foreach (Employee x in all)
            {
                //COMPARE VALUE OF EACH ITEM IN 'all' WITH STRING VALUE OF "Joe", AND IF SO ADD THE ITEM TO THE NEW 'List<Employee> joes'
                if (x.firstName == "Joe")
                {
                    Console.WriteLine("\t" + x.firstName + " " + x.lastName);
                    joes.Add(x);
                }               
            }

            //FORMATTING
            Console.WriteLine("\n\tTHIS PRINTS EACH \'joe\' IN THE LIST OF \'joes\'\n");

            //DISPLAY THE EMPLOYEE DATA FOR EACH EMPLOYEE NAMED 'joe' FROM 'List<Employee joes'
            foreach (Employee joe in joes)
            {
                Console.WriteLine("\t" + joe);
            }

            //FORMATTING
            Console.WriteLine("\n\tTHIS USED A LAMBDA EXPRESSION TO DO THE SAME THING AS ABOVE\n");

            //USE LAMBDA TO CREATE A NEW 'List<Employee>' FOR ALL EMPLOYEES NAMED 'Joe'
            List<Employee> newList = all.Where(x => x.firstName == "Joe").ToList();

            //DISPLAY VALUE OF EACH ITEM 'x' IN LIST 'newList' WITH A VALUE OF 'Joe'
            newList.ForEach(x => Console.WriteLine("\t" + x));

            //FORMATTING
            Console.WriteLine("\n\tTHIS USED A LAMBDA EXPRESSION TO MAKE A LIST OF ALL EMPLOYEES WITH AN ID NUMBER > 5\n");

            //USE A LAMBDA TO MAKE A LIST OF ALL EMPLOYEES WITH WITH AN ID NUMBER GREATER THAN 5.
            List<Employee> newNewList = all.Where(x => x.ID > 5).ToList();

            //DISPLAY VALUE OF EACH ITEM 'x' IN LIST 'newList' WITH A VALUE OF 'Joe'
            newNewList.ForEach(x => Console.WriteLine("\t" + x));

            Console.ReadLine();
        }
    }
}