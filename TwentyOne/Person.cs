using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Person
    {
        //PUBLIC STRING PROPERTIES 'FirstName', 'LastName', AND 'Info'
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }

        //DECLARE ABSTRACT METHOD (ALL INHERITING CLASSES MUST IMPLEMENT THE 'FullName()' METHOD
        public abstract void employeeInfo(int Id, string FirstName, out string Info, string LastName);
    }
}


