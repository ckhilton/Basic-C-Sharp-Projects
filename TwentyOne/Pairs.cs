using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Pairs
    {
        //OVERLOADED METHOD WITH OUTPUT PARAMETER
        public void Shoes(int total, out int pairs)
        {
            //DIVIDE INPUT BY 2
            pairs = total / 2;
        }
        //OVERLOAD METHOD 'Shoes'
        public void Shoes(float size, out string description, string brand)
        {
            description = "SIZE " + size + " " + brand.ToUpper() + "\'S";
        }
    }   
}
   


