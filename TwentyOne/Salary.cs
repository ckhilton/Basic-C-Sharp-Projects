using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Salary
    {
        //TAKES 2 INTEGERS (DISPLAYS 2ND INTEGER)
        public void Gross(int daily = 8, int weekly = 40)
        {
            int annual = daily * 260;
            Console.WriteLine("A STANDARD WORK WEEK IS " + weekly + " HOURS.");
        }
    }
}
   


