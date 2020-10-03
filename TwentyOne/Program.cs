using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE NEW OBJECT
            Number myAccount = new Number();
            //ASSIGN AMOUNT TO NEW OBJECT 'myAccount'
            myAccount.Amount = 0.00F;
            //DISPLAY OUTPUT
            Console.WriteLine("\n\tMY CURRENT BANK ACCOUNT BALANCE: " + String.Format("{0:C}", myAccount.Amount));
            
            Console.ReadLine();
        }      
    }
}
