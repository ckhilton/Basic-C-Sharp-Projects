using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    public class Date
    {
        public Month Month { get; set; }
        public Day Day { get; set; }
    }
    
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }       
    
    public enum Month
    {
        January=1,
        February=2,
        March=3,
        April=4,
        May=5,
        June=6,
        July=7,
        August=8,
        September=9,
        October=10,
        November=11,
        December=12
    }
}
