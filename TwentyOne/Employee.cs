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
        public Employee(int access, string first, string last, string dob) : this(access, first, last, dob, "(WE WILL ENTER THIS INFO LATER)")
        {
        }
        public Employee(int access, string first, string last, string dob, string department)
        {
            AccessID = access;
            First = first;
            Last = last;
            DOB = dob;
            Department = department;
            Full = new List<string> { AccessID.ToString(), First, Last, DOB, Department };
            EmpID = new Guid();
        }

        public int AccessID { get; set; }       
        public Guid EmpID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string DOB { get; set; }
        public string Department { get; set; }
        public List<string> Full { get; set; }

        public void Verify()
        {
            Console.WriteLine("\n------------------------ FINAL VERIFICATION!!! ------------------------" +
                "\n\n(PLEASE CHECK YOUR INFORMATION BELOW FOR ACCURACY)" +
                "\n\n\tYOUR 4-DIGIT ACCESS ID: {0}" +
                "\n\n\tNAME (LAST, FIRST): {2}, {1} " +
                "\n\n\tDOB: {3}" +
                "\n\n\tDEPARTMENT: {4}", AccessID, First, Last, DOB, Department);
            //VERIFY THAT EVERYTHING LOOKS CORRECT
            Console.Write("\nTO CONFIRM AND SAVE, ENTER YOUR UNIQUE 4-DIGIT ONLINE ACCESS ID." +
                "\n\n(TO GO BACK OR MAKE CHANGES ENTER \"0000\")");

            //CONTROLLED DO-WHILE LOOP TO ESTABLISH AND SAVE THE CORRECT ID
            bool go = true;          
            do
            {
                Console.Write("\n\n\tACCESS ID: ");
                int accessID = Convert.ToInt32(Console.ReadLine());
                bool verified = accessID == AccessID;

                //CONDITIONS IF EVERYTHING IS ACCURATE AND THE 'AccessID' MATCHES THE ANSWER IN INTEGER FORM AS VARIABLE 'accessID'
                if (verified == true)
                {
                    go = false;
                }
                //IF THE USER TYPED IN THE 'AccessID' WRONG
                if (verified == false && accessID != 0000)
                {
                    Console.Write("\nINCORRECT ACCESS ID: PLEASE TRY AGAIN");
                    go = true;
                }
                //CONDITIONS IF THE USER WANTS TO GO BACK AND MAKE CHANGES
                if (accessID == 0000)
                {
                    return;
                }
            }
            while (go);
        }
    }
}
