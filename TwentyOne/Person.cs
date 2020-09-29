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
        public List<string> Employees { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //DECLARE ABSTRACT METHOD (ALL INHERITING CLASSES MUST IMPLEMENT THE 'SayName()' METHOD
        public abstract void SayName();
    }
}