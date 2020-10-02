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
            bool run = true;
            do
            {
                try
                {

                    //GET USER INPUT FOR FIRST NAME 
                    Console.Write("\n" +
                        "\n\tPLEASE ENTER THE CURRENT DAY OF THE WEEK: ");
                    string input = Console.ReadLine();

                    Day today;

                    today = (Day)Enum.Parse(typeof(Day), input);
                    Console.WriteLine("\n\tTODAY IS: " + input.ToUpper());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n\tPLEASE ENTER AN ACTUAL DAY OF THE WEEK");
                    Console.WriteLine("\n\t" + ex.Message.ToUpper());
                }
                finally
                {
                    Console.WriteLine("\n\tYOU HAVE EXITED THE TRY-CATCH LOOP");
                    Console.Write("\n" +
                        "\t\n\tPRESS ENTER ENTER TO RUN THE PROGRAM AGAIN" +
                        "\n\n\t\t OR" +
                        "\n\n\tPRESS 'X' TO EXIT THE PROGRAM: ");
                    string stop = Console.ReadLine();
                    if (stop.ToUpper() == "X")
                    {
                        run = false;
                        Console.WriteLine("\n=======================" +
                            "\n\n\tPRESS ENTER");
                    }
                }
            }
            while (run);
            Console.ReadLine();
        }
    }
}

