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
        public void Gross(int daily, int weekly)
        {
            int annual = daily * 260;
            //OUTPUT
            Console.WriteLine("\n\tTHIS WEEK YOU WORKED: " +
                "\n\n\t\t" + weekly + " HOURS " +
                "\n\n\tIF YOU WORK ALL YEAR WITH A DAILY AVERAGE OF" + daily + " HOURS PER DAY... " +
                "\n\n\t\t YOUR ANNUAL TOTAL HOURS WORKED WOULD BE: " + annual);  
        }
    }
}
   


