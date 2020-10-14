using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        //CREATING 2 CONSTRUCTORS, ONE OF THEM OVERLOADING THE OTHER AND HAVING THEM IMPLEMENT THE EXACT SAME IMPLEMENTATION THAT EXISTS FOR EXCEPTION
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
