using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTROL INFINITE LOOP TO TEST MULTIPLE TIMES
            bool run = true;
            do
            {
                try
                {
                    DateTime now = DateTime.Now;
                    Console.Write("ENTER HOW MANY YEARS OLD YOU ARE: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0)
                    {
                        throw new FormatException();
                    }

                    Console.Write("ENTER THE MONTH YOU WERE BORN IN (AS A NUMBER): ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    //RANGE FOR MONTH TO BE VALID
                    if (month < 1 || month > 12)
                    {
                        throw new FormatException();
                    }

                    Console.Write("ENTER THE DAY OF THE MONTH YOU WERE BORN ON (AS A NUMBER): ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    //RANGE FOR DAY TO BE VALID
                    if (day < 0 || day > 31)
                    {
                        throw new FormatException();
                    }

                    //CURRENT YEAR NOW
                    int year = 2020;

                    DateTime bday = new DateTime(year, month, day);
                    if (bday < DateTime.Now)
                    {
                        int yearBorn = year - age;
                        Console.WriteLine("SINCE YOU TURNED {0} ON {1}, YOU WERE BORN IN THE YEAR {2}\n", age, bday, yearBorn);
                    }
                    if (bday > DateTime.Now)
                    {
                        int turning = age + 1;
                        int yearBorn = year - age - 1;
                        Console.WriteLine("SINCE YOU TURN {0} ON {1}, YOU WERE BORN IN THE YEAR {2}\n", turning, bday, yearBorn);
                    }
                }
                //EXCEPTION HANDLING
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message.ToUpper() + " PLEASE ENTER POSITIVE NUMBERS ONLY; CANNOT BE ZERO");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToUpper());
                }
            }
            while (run);
            Console.Read();
        }
    }
}