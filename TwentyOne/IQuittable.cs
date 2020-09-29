using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IQuittable
    {
        void Quit();
    }
}

namespace TwentyOne
{
    interface IWalkAway
    {
        void WalkAway(Player player); //EVERYTHING IS AUTOMATICALLY PUBLIC IN AN INTERFACE
    }
}

//*INTERFACE RULES:
//      1) NAMING CONVENTION ALWAYS STARTS WITH THE CAPITAL LETTER 'I'
//      2) EVERYTHING IS AUTOMATICALLY PUBLIC
//      3) CLASSES CAN INHERIT AS MANY INTERFACES AS DESIRED
//      4) INTERFACES ARE SIMILAR TO ABSTRACT CLASSES IN THAT THERE ARE NO IMPLEMENTATION DETAILS


