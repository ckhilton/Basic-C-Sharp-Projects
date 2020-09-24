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
        public int hourly { get; set; }
        public int gross { get; set; }
        public int tax { get; set; }
        public int net { get; set; }
        public int tithing { get; set; }
        public int newNet { get; set; }

        //SIMPLE MATH METHODS/FUNCTIONS
        public static int Gross(int hourly)
        {
            int gross = hourly * 2080;
            return gross;
        }
      
        public static int Tax(int gross)
        {
            int tax = gross * 30 / 100;
            return tax;
        }

        public static int Net(int gross)
        {
            int net = gross - Tax(gross);
            return net;
        }

        public static int Tithe_Gross(int gross)
        {
            int titheGross = gross * 10 / 100;
            return titheGross;
        }

        public static int Tithe_Net(int net)
        {
            int titheNet = net * 10 / 100;
            return titheNet;
        }

        public static int Net_Tithe_Gross(int net, int titheGross)
        {
            int netTitheGross = net - titheGross;
            return netTitheGross;
        }

        public static int Net_Tithe_Net(int net, int titheNet)
        {
            int netTitheNet = net - titheNet;
            return netTitheNet;
        }        
    }    
}