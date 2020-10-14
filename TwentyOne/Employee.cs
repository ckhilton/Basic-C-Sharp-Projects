using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Employee
    {
        //CREATE POTENTIAL FOR CONSTRUCTOR CHAINING
        public Employee(int id, string first, string last, string dob) : this(id, first, last, dob, "(WE WILL ENTER THIS INFO LATER)")
        {
        }
        public Employee(int id, string first, string last, string dob, string department)
        {
            ID = id;
            First = first;
            Last = last;
            DOB = dob;
            Department = department;
            Full = new List<string> { ID.ToString(), First, Last, DOB, Department };

        }

        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string DOB { get; set; }
        public string Department { get; set; }    
        public bool Validate { get; set; }

        public List<string> Full { get; set; }

        public void Verify()
        {
            if (Validate == true)
            {
                Console.WriteLine("\nPLEASE VERIFY YOUR INFO IS ACCURATELY DISPLAYED BELOW: " +
                "\n\n\tYOUR 4-DIGIT ACCESS ID: {0}" +
                "\n\n\tLAST NAME, FIRST: {2}, {1} " +
                "\n\n\tDOB: {3}" +
                "\n\n\tDEPARTMENT: {4}", ID, First, Last, DOB, Department);
                //VERIFY THAT EVERYTHING LOOKS CORRECT
                Console.Write("\nIF EVERYTHING IS ACCURATE, TYPE YOUR ID AGAIN TO STORE YOUR INFO IN OUR SYSTEM: ");
                int verified = Convert.ToInt32(Console.ReadLine());
                
                bool go = true;
                do
                {
                    if (verified == ID)
                    {
                        
                    }
                }
                while (go);
            }
            return;
        }
    }
}
