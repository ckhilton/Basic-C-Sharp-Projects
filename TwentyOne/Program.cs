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
            Console.WriteLine("WELCOME TO THE GRAND HOTEL AND CASINO. LET'S START BY TELLING ME YOUR NAME.");
            string playerName = Console.ReadLine().ToUpper();
            Console.WriteLine("HELLO {0}! HOW MUCH MONEY DID YOU BRING TODAY?", playerName);
            string playerBank = Console.ReadLine();

            //WRITE THE 'playerBank' AMOUNT TO THE FILE 'PlayerLog.txt'
            File.WriteAllText(@"C:\Users\Student\Desktop\Basic_C#_Programs - Copy\TwentyOne\TwentyOne\ZZ_PlayerLog.txt", playerBank);
            
            //READS ALL TEXT FROM 'PlayerLog.txt' AND STORES IT IN A STRING VARIABLE CALLED 'text'
            string text = File.ReadAllText(@"C:\Users\Student\Desktop\Basic_C#_Programs - Copy\TwentyOne\TwentyOne\ZZ_PlayerLog.txt");
            Console.WriteLine("IT LOOKS LIKE YOU'VE BROUGHT ${0} TODAY! LET'S PLAY SOME 21!", text);

            Console.ReadLine();
        }
    }
}
