using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Person
    {       
        //PUBLIC STRING PROPERTIES 'FirstName' AND 'LastName'
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //PUBLIC VOID METHOD WITH NO INPUTS
        public void SayName()
        {
            //DISPLAY PERSONS FULL NAME TO THE CONSOLE
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
