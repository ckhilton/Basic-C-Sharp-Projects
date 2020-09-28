using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Salary
    {
        //SET ATTRIBUTES TO PUBLIC AND ALLOW GET:SET
        public int hours { get; set; }
        public int hourly { get; set; }
        public string number { get; set; }

        //SIMPLE MATH METHODS/FUNCTIONS

        //TAKES AN INT AND RETURNS AN INT
        public static int Gross(int hours, int hourly)
        {
            int gross = hours * hourly;
            return gross;
        }

        ////TAKES A DECIMAL/FLOAT AND RETURNS AN INTEGER
        //public static int Gross(float hourly)
        //{
        //    float gross = hourly * 2080;
        //    return Convert.ToInt32(gross);
        //}

        ////TAKES A STRING AND RETURNS AN INTEGER
        //public static int Gross(string number)
        //{
        //    int days = 260 - int.Parse(number);
        //    return days;
        //}   
    }    
}