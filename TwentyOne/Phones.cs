using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //DECLARE STATIC CLASS 'Phones'
    public static class Phones
    {
        //METHOD WITH OUTPUT PARAMETERS
        public static void Bill(float total, out float each, out float yearly)
        {
            //DIVIDE INPUT BY 2 FOR MONTHLY
            each = total / 2;
            yearly = each * 12;

        }
    }
}
