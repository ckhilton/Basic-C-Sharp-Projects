using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) //***NOTE: AN ACCESS MODIFIER EXAMPLE IS 'public', WHICH WOULD GIVE ACCESS TO THE FUNCTION FROM THE REST OF THE PROGRAM
        {
            //============================= STEP 216 ASSIGNMENT =============================
            Console.Write("\n===================================== STEP 219 ASSIGNMENT ===========================================\n" +
                "\n  THIS CONSOLE APP WILL...\n");
            //CONTROL VARIABLE
            bool executing = true;

            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
            do
            {
                //THE CODE I WANT TO WORK
                try
                {
                    Console.WriteLine("\n=========================================== START ===================================================\n");
                    //USER INSTRUCTIONS
                    Console.WriteLine("\tHOW MANY HOURS DO YOU WORK IN A TYPICAL WORK-WEEK? (NO DECIMALS) ");                   
                    //GET USER INPUT 
                    int hours = Convert.ToInt32(Console.ReadLine());
                    //CALL FUNCTION
                    int annualHours = Salary.Gross(hours);
                    //OUTPUT/USER INFO FOR ANNUAL AVERAGE
                    Console.WriteLine("\tBASED ON WORKING " + hours + " HOURS PER WEEK, YOU WILL WORK APPROX... " +
                        "\n\n\t" + annualHours + " HOURS ANNUALLY");

                    ////USER INSTRUCTIONS
                    //Console.WriteLine("\tENTER AN HOURLY WAGE: ");s
                    ////GET USER INPUT AS A DECIMAL
                    //float hour = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("\n\t----------------------------------------------------");
                    
                    
                    ////CALL FLOAT-TO-INTEGER VERSION OF FUNCTION
                    //float grossWeekly = Salary.Gross(hours);
                    //Console.WriteLine("\n\t  - YOUR AVERAGE GROSS WEEKLY INCOME:\t" + String.Format("{0:C}", grossWeekly));


                    
                    ////OUTPUT/GIVE USER INFORMATION FOR ANNUAL SALARY
                    //Console.WriteLine("\n\tBASED ON AN HOURLY WAGE OF " + String.Format("{0:C}", hourly) + " PER HOUR ..." +
                    //    "\n\n\tYOUR ANNUAL SALARY INFORMATION IS AS FOLLOWS ...");
                    ////CALL INTEGER-TO-INTEGER VERSION OF FUNCTION
                    //int gross = Salary.Gross(hourly);
                    //Console.WriteLine("\n\t  - GROSS ANNUAL INCOME:\t" + String.Format("{0:C}", gross));

                    
                    
                }

                //    int tax = Salary.Tax(gross);
                //    Console.WriteLine("\n\t  - AVERAGE TOTAL TAX:\t\t" + String.Format("{0:C}", tax) + " ***");

                //    int net = Salary.Net(gross);
                //    Console.WriteLine("\n\t  - RAW NET ANNUAL INCOME:\t" + String.Format("{0:C}", net));

                //    //ADDITIONAL INFO FOR USER
                //    Console.WriteLine("\n\tHERE IS SOME ADDITIONAL HELPFUL INFORMATION ..." +
                //        "\n\n\t\t(PRESS ENTER)");
                //    Console.ReadLine();

                //    //CALL TITHING/CHARITY FUNCTIONS
                //    int titheGross = Salary.Tithe_Gross(gross);
                //    int titheNet = Salary.Tithe_Net(net);
                //    int netTitheGross = Salary.Net_Tithe_Gross(net, titheGross);
                //    int netTitheNet = Salary.Net_Tithe_Net(net, titheNet);

                //    //DISPLAY INFORMATION/OUTPUT
                //    Console.WriteLine("\tA GENEROUS RELIGIOUS TITHE OR CHARITY DONATION OF 10% ..." +
                //        "\n\n\t  - ON YOUR GROSS INCOME IS:\t" + String.Format("{0:C}", titheGross) +
                //        "\n\n\t  - ON YOUR NET INCOME IS:\t" + String.Format("{0:C}", titheNet) +
                //        "\n\n\t\t(PRESS ENTER)");
                //    Console.ReadLine();

                //    Console.WriteLine("\t----------------------------------------------------------------------" +
                //        "\n\n\tHERE ARE YOUR NET ANNUAL INCOME VARIANCE TOTALS: " +                       
                //        "\n\n\tAFTER TAXES AND 10% TITHE OF GROSS:\t( NET TOTAL ) " + String.Format("{0:C}", netTitheGross) +
                //        "\n\n\tAFTER TAXES AND 10% TITHE OF NET:\t( NET TOTAL ) " + String.Format("{0:C}", netTitheNet) +
                //        "\n\n\tAFTER TAXES WITHOUT ANY DONATIONS:\t( NET TOTAL ) " + String.Format("{0:C}", net) +
                //        "\n\n\t*********************************************************************************" +
                //        "\n\tDISCLAIMER: THIS APP DOES NOT TAKE TAX BREAKS INTO CONSIDERATION. BUT YOU SHOULD!" +
                //        "\n\t*********************************************************************************" +                                  
                //        "\n\n\t(PRESS ENTER)");
                //    Console.ReadLine();
                //}

                //================ EXCEPTION HANDLING ================              
                //WRONG FORMAT CATCH
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\tTISK TISK, WRONG FORMAT!!! " +
                        "\n\n\t   - TEXT NOT ALLOWED. " +
                        "\n\n\t   - WHOLE NUMBERS ONLY. " +
                        "\n\n\t   - NULL IS NOT ACCEPTABLE EITHER." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                }
                //GENERAL CATCH IF TOO LARGE OF OR TOO SMALL OF AN INTEGER WERE ENTERED
                catch (Exception ex)
                {
                    Console.WriteLine("\n\tEASY DOES IT THERE!!!" +
                        "\n\n\t   - YOUR " + ex.Message.ToUpper() +
                        "\n\n\t   - NOT TOO BIG." +
                        "\n\n\t   - NOT TOO NEGATIVE." +
                        "\n\n\t   - NICE AND EASY." +
                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
                    Console.ReadLine();
                }
                //INSTRUCTIONS TO USER
                finally
                {
                    //PROGRAM NOTE   
                    Console.Write("======================================= END TRY/CATCH ===============================================\n" +
                        "\n\t             ---- (PRESS ENTER TO TRY ANOTHER HOURLY WAGE) ----\n\n" +
                        "\t\t\t\t            OR\n\n" +
                        "\t\t        XXX (PRESS \'X\' TO SEE REFERENCE/SOURCE) XX");
                        
                    string exit = Console.ReadLine();
                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
                    if ((exit == "x") || (exit == "X"))
                    {
                        executing = false;
                    }
                }
            }
            while (executing);

            //DISCLAIMER AND REFERENCES FOR USER
            Console.WriteLine("\n=====================================================================================================");

            Console.WriteLine("\nREFERENCE: " +
                "\n\n*** THE AVERAGE SINGLE AMERICAN GAVE 29.6% TO 3 TAXES IN 2018: INCOME, MEDICARE, AND SOCIAL SECURITY.\n" +
                "\nSOURCE: " +
                "\n\nhttps://www.thebalance.com/what-the-average-american-pays-in-taxes-4768594#:~:text=The%20average%20income%20tax%20rate,one%20study%20of%20BLS%20numbers.");
            Console.WriteLine("\n(PRESS ENTER TO CLOSE WINDOW)\n");
            Console.ReadKey(true);
        }
    }
}

//namespace TwentyOne
//{
//    class Program
//    {
//        //***RULES TO A METHOD/FUNCTION: ACCESS MODIFIER, RETURN TYPE 'voic', A NAME 'Main', PARAMETERS '(string[] args), METHODS ALSO HAVE TO BE PART OF A CLASS. IF...
//        //...A METHOD IS BEING USED WITHOUT FIRST CREATING AN OBJECT OF THAT CLASS THEN IT HAS TO BE MARKED AS 'static'
//        static void Main(string[] args) //***NOTE: AN ACCESS MODIFIER EXAMPLE IS 'public', WHICH WOULD GIVE ACCESS TO THE FUNCTION FROM THE REST OF THE PROGRAM
//        {
//            Deck deck = new Deck(); //INSTANTIATE AN OBJECT FROM THE CLASS 'Public Class Deck' AND NAMED IT 'deckNew' (EMPTY/NO VALUES ASSIGNED YET)
//            int timesShuffled = 0;
//            deck = Shuffle(deck, out timesShuffled, 3); //'out timesShuffled' SENDS THE OUTPUT TO 'int timesShuffled = 0' (ABOVE) INSTEAD OF ASSIGNING IT TO 'deck'.

//            /*deck = Shuffle(deck, 3); *///THIS JUST ADDS A PARAMETER FOR THE NUMBER OF TIMES TO SHUFFLE THE DECK BASED ON THE OLD/NOT USED/LESS EFFICIENT CODE (THAT WAS COMMENTED OUT) RIGHT BELOW THE SHUFFLE DECK FUNCTION.
//            /*deck = Shuffle(deck: deck, times: 3);*/ //THIS IS A NAMED PARAMETER. IT'S THE EXACT SAME AS THE COMMENTED OUT CODE IMMEDIATELY ABOVE THIS LINE, BUT IT MAKES THE CODE EASIER TO READ

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
//            }

//            //Console.WriteLine(deckNew.Cards[0].Face + " of " + deckNew.Cards[0].Suit);
//            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//            Console.WriteLine("\n\tTIMES SHUFFLED: {0}", timesShuffled);
//            Console.ReadLine();

//        }

//        //SHUFFLE THE DECK
//        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
//        {
//            timesShuffled = 0;
//            for (int i = 0; i < times; i++)
//            {
//                timesShuffled++;
//                List<Card> TempList = new List<Card>();
//                Random random = new Random();

//                while (deck.Cards.Count > 0)
//                {
//                    int randomIndex = random.Next(0, deck.Cards.Count);
//                    TempList.Add(deck.Cards[randomIndex]);
//                    deck.Cards.RemoveAt(randomIndex);
//                }
//                deck.Cards = TempList;
//            }

//            return deck;
//        }

//        //public static Deck Shuffle(Deck deck, int times) //THIS GOT COMMENTED OUT BECAUSE WE USED A DEFAULT PARAMETER TO DO THE SAME THING ON THE METHOD ABOVE INSTEAD
//        //{
//        //    for (int i = 0; i < times; i++ )
//        //    {
//        //        deck = Shuffle(deck);
//        //    }
//        //    return deck;
//        //}
//    }
//}



////================= OLD/SLOWER VERSION OF TYPING OUT CODE THAT WAS UPGRADED BY THE MORE EFFICIENT CODE THAT'S USED ABOVE =============

////deckNew.Cards = new List<Card>(); //MAKE THE PROPERTY 'Cards' INTO A BLANK LIST. REMEMBER THE CLASS "Public Deck" HAS ONLY 1 PROPERTY (WHICH IS A DATA TYPE OF LIST, CALLED 'Public List<Card> Cards')

////======== ...AND ALL OF THIS CODE WAS MOVED INTO THE CLASS 'Decks' FOR EASE OF CREATING NEW DECKS===============
////Card cardOne = new Card();
////cardOne.Face = "Queen";
////cardOne.Suit = "Spades";
////deckNew.Cards.Add(cardOne);