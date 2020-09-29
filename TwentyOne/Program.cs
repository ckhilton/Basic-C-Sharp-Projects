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
            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee employee = new Employee() { FirstName = "Sample ", LastName = "Student" };
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' CLASS OBJECT NAMED 'person'
            employee.Quit(employee); 
            
            Console.ReadLine();          
        }
    }
}


