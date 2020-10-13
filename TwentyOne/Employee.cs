using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Employee
    {
        //CREATE POTENTIAL FOR CONSTRUCTOR CHAINING
        public Employee(int id) : this(id, 1)
        {
        }
        public Employee(int id, int department)
        {
            Full = new string[] { Last, First };
            ID = id;
            Department = department;

        }
        public string[] Full { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public int Department { get; set; }
        public string DOB { get; set; }
        public bool Valid { get; set; }

        public void Display()
        {
            if (Valid == true)
            {
                Console.WriteLine("GLAD TO HAVE YOU BACK {0}!" +
                "\n\nPLEASE VERIFY ALL OF THE INFORMATION BELOW:" +
                "\n\n\tFULL NAME: {1}, {0}" +
                "\n\n\tAGE: {2}" +
                "\n\n\tDEPARTMENT: {3}" +
                "\n\n\tEMPLOYEE ID: {4}", Last, First, DOB, Department, ID);
            }     
        }
    }
}
