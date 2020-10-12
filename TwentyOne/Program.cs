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
            //PRINTS THE CURRENT DATE AND TIME TO THE CONSOLE
            DateTime now = DateTime.Now;
            Console.WriteLine("CURRENT DATE AND TIME: {0}", now);

            //ASKS USER FOR ANY NUMBER AND STORES AS A VALUE DATA TYPE DOUBLE NAMED 'answer'
            Console.Write("\nPLEASE TYPE IN ANY NUMBER: ");
            double answer = Convert.ToDouble(Console.ReadLine());

            //CREATE NEW DATETIME CALLED 'future' AND USE THE METHOD 'AddHours' TO THE  VALUE OF 'now'
            DateTime future = now.AddHours(answer);

            //PRINTS THE EXACT TIME IT WILL BE IN X HOURS, WHERE X IS THE NUMBER THE USER ENTERED
            Console.Write("\nIN {0} HOURS, THE EXACT DATE AND TIME WILL BE: {1}", answer, future);

            Console.ReadLine();
        }
    }
}