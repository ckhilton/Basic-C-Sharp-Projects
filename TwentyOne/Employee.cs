using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CREATE CLASS 'Employee' THAT INHERITS SUPERCLASS 'Person' 
    public class Employee : Person
    {
        //IMPLEMENT THE ABSTRACT 'Person' CLASS 'SayName()' METHOD
        public override void SayName()
        {
            //DISPLAY FULL NAME TO CONSOLE USING INPUT CONTROL METHOD '.ToUpper()'
            Console.WriteLine("NAME: " + FirstName.ToUpper() + LastName.ToUpper());
        }           
    }    
}