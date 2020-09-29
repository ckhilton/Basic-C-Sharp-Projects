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
            Console.WriteLine("NAME: " + FirstName + LastName);
        }           
    }    
}