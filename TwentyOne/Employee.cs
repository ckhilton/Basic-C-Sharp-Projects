using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Employee
    {
        public Employee(int id) : this(id, 1)
        {
        }
        public Employee(int id, int department)
        {
            Full = new string[] { First, Last };
            ID = id;
            Department = department;
            
        }
        public string[] Full { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public int Department { get; set; }
        public int Age { get; set; }

        public string Create()
        {

        }

    }
}
