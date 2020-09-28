using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Salary
    {

        //SET ATTRIBUTES TO PUBLIC AND ALLOW GET:SET
        public int hours { get; set; }
        public int hourly { get; set; }
        public int gross { get; set; }
       

        //TAKES 2 INTEGERS (2ND IS OPTIONAL) AND RETURNS AN INT
        public static int Gross(int hourly, int hours = 40)
        {
            int gross = hourly * hours;
            return gross;                    
        }
    }
}






//class Program
//{
//    //***RULES TO A METHOD/FUNCTION: ACCESS MODIFIER, RETURN TYPE 'voic', A NAME 'Main', PARAMETERS '(string[] args), METHODS ALSO HAVE TO BE PART OF A CLASS. IF...
//    //...A METHOD IS BEING USED WITHOUT FIRST CREATING AN OBJECT OF THAT CLASS THEN IT HAS TO BE MARKED AS 'static'
//    static void Main(string[] args) //***NOTE: AN ACCESS MODIFIER EXAMPLE IS 'public', WHICH WOULD GIVE ACCESS TO THE FUNCTION FROM THE REST OF THE PROGRAM
//    {
//        Deck deck = new Deck(); //INSTANTIATE AN OBJECT FROM THE CLASS 'Public Class Deck' AND NAMED IT 'deckNew' (EMPTY/NO VALUES ASSIGNED YET)
//        int timesShuffled = 0;
//        deck = Shuffle(deck, out timesShuffled, 3); //'out timesShuffled' SENDS THE OUTPUT TO 'int timesShuffled = 0' (ABOVE) INSTEAD OF ASSIGNING IT TO 'deck'.

//        /*deck = Shuffle(deck, 3); *///THIS JUST ADDS A PARAMETER FOR THE NUMBER OF TIMES TO SHUFFLE THE DECK BASED ON THE OLD/NOT USED/LESS EFFICIENT CODE (THAT WAS COMMENTED OUT) RIGHT BELOW THE SHUFFLE DECK FUNCTION.
//        /*deck = Shuffle(deck: deck, times: 3);*/ //THIS IS A NAMED PARAMETER. IT'S THE EXACT SAME AS THE COMMENTED OUT CODE IMMEDIATELY ABOVE THIS LINE, BUT IT MAKES THE CODE EASIER TO READ

//        foreach (Card card in deck.Cards)
//        {
//            Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());
//        }

//        //Console.WriteLine(deckNew.Cards[0].Face + " of " + deckNew.Cards[0].Suit);
//        Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
//        Console.WriteLine("\n\tTIMES SHUFFLED: {0}", timesShuffled);
//        Console.ReadLine();

//    }

//    //SHUFFLE THE DECK
//    public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
//    {
//        timesShuffled = 0;
//        for (int i = 0; i < times; i++)
//        {
//            timesShuffled++;
//            List<Card> TempList = new List<Card>();
//            Random random = new Random();

//            while (deck.Cards.Count > 0)
//            {
//                int randomIndex = random.Next(0, deck.Cards.Count);
//                TempList.Add(deck.Cards[randomIndex]);
//                deck.Cards.RemoveAt(randomIndex);
//            }
//            deck.Cards = TempList;
//        }

//        return deck;
//    }


//    namespace TwentyOne
//{
//    public class Card //PUBLIC SIMPLY MEANS THAT IT'S AVAILABLE TO THE ENTIRE PROGRAM
//    {
//        //EXAMPLE OF CREATING A CONSTRUCTOR FOR A DEFAULT VALUE
//        public Card()
//        {
//            Suit = "Spades";
//            Face = "Two";
//        }
//        public string Suit { get; set; }
//        public string Face { get; set; }
//    }
//}




////TAKES A DECIMAL/FLOAT AND RETURNS AN INTEGER
//public static int Gross(float hourly)
//{
//    float gross = hourly * 2080;
//    return Convert.ToInt32(gross);
//}

////TAKES A STRING AND RETURNS AN INTEGER
//public static int Gross(string number)
//{
//    int days = 260 - int.Parse(number);
//    return days;
//}   
