using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CREATE CLASS 'Employee' THAT INHERITS SUPERCLASS 'Person' 
    public class Employee : Person, IQuittable
    {
        //IMPLEMENT THE ABSTRACT 'Person' CLASS 'SayName()' METHOD
        public override void FullName(string FirstName, out string Full, string LastName)
        {
            Full = FirstName + " " + LastName;
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("\tCOMPANY: \"YOU QUIT ALREADY?\"" +
                "\n\n\tYOU: \"YEP, AND IT'S A GOOD THING TOO!!!\"");           
        }
    }    
}