using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    public class Date
    {
        public
        public Day Day { get; set; }
    }
    
    public enum Day
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
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
