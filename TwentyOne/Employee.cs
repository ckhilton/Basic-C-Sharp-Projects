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
        //CREATE PUBLIC PROPERTY 'Id' AS TYPE INTEGER
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        //IMPLEMENT 'Person' CLASS 'employeeInfo()' METHOD
        public override void employeeInfo(int Id, string FirstName, out string Info, string LastName)
        {
            Info = "EMPLOYEE: " + FirstName.ToUpper() + " " + LastName.ToUpper() +
            "\n\n\tID: " + Id;
        }
    }
}