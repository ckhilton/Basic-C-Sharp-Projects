using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CREATE CLASS 'Employee' THAT INHERITS SUPERCLASS 'Person' 
    public class Employee
    {
        public Employee(int ID, string firstName, string lastName)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }  
}


    //    //CREATE PUBLIC PROPERTY 'Id' AS TYPE INTEGER
    //    public int Id { get; set; }

    //    public static bool operator ==(Employee employee1, Employee employee2)
    //    {
    //        if (employee1.Id == employee2.Id) 
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }

    //    }
    //    public static bool operator !=(Employee employee1, Employee employee2)
    //    {
    //        if (employee1.Id != employee2.Id)
    //        {
    //            return true; 
    //        }
    //        else
    //        {
    //            return false;
    //        }
            
    //    }

    //    //IMPLEMENT 'Person' CLASS 'employeeInfo()' METHOD
    //    public override void employeeInfo(int Id, string FirstName, out string Info, string LastName)
    //    {
    //        Info = "EMPLOYEE: " + FirstName.ToUpper() + " " + LastName.ToUpper() +
    //        "\n\n\tID: " + Id;
    //    }
    //}