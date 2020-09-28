using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Salary
    {
        //TAKES 2 INTEGERS (2ND IS OPTIONAL) AND RETURNS AN INT
        public static int Gross(int hourly, int hours = 40)
        {
            int gross = hourly * hours * 52;
            return gross;                    
        }
    }
}