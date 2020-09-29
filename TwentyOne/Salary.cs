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
        public void Gross(int daily, int wage)
        {
            int weekly = daily * 5;
            int annual = daily * 260;
            int salary = weekly * 52 * wage;
            //OUTPUT
            Console.WriteLine("\n\tIF YOU WORK " + daily + " EVERY DAY THIS WEEK, YOU'LL PUT IN: " +
                "\n\n\t\t" + weekly + " HOURS @ "  + string.Format("{0:C}", wage) + "/HR" + 
                "\n\n\tIF YOU WORK ALL YEAR WITH A DAILY AVERAGE OF " + daily + " HOURS PER DAY... " +
                "\n\n\t\tYOUR ANNUAL TOTAL HOURS WORKED WOULD BE: " + annual +
                "\n\n\t\tYOUR TOTAL ANNUAL SALARY WOULD BE: " + string.Format("{0:C}", salary) + "\n");  
        }
    }
}
   


