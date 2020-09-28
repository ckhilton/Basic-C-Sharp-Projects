using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Salary
    {
        //SET DEFAULT VALUE FOR INTEGER HOURS
        public Salary()
        {
            int hours = 2080;
        }
       

        //TAKES AN INT AND RETURNS AN INT
        public static int Gross(int hourly, int hours)
        {
            int gross = hourly * hours;
            return gross;
        }

        //SET ATTRIBUTES TO PUBLIC AND ALLOW GET:SET
        public int hours { get; set; }
        public int hourly { get; set; }
       



        //    namespace TwentyOne
        //{
        //    public class Card //PUBLIC SIMPLY MEANS THAT IT'S AVAILABLE TO THE ENTIRE PROGRAM
        //    {
        //        //EXAMPLE OF CREATING A CONSTRUCTOR FOR A DEFAULT VALUE
        //        public Card()
        //        {
        //            Suit = "Spades";
        //            Face = "Two";
        //        }
        //        public string Suit { get; set; }
        //        public string Face { get; set; }
        //    }
        //}




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