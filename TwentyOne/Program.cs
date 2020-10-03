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
            Deck deck = new Deck();


            //LAMBDA EXPRESSIONS ARE:
            //HARD TO DEBUG
            //CAN'T STEP THROUGH LAMBDA EXPRESSIONS UPON EACH LOOP OF THE CODE
            //TOO MUCH LOGIC IN ONE LONG LAMBDA EXPRESSION CAN GET VERY COMPLICATED TO READ/UNDERSTAND

            ////======================================== SNIPPET ========================================
            ////HOW TO CHECK HOW MANY OF A CERTAIN CARD EXISTS IN THE DECK (TEDIOUS TO WRITE AND NOT AS EASY TO READ, ALSO NOT AS FAST WHEN IT RUNS)
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            ////====================================== END SNIPPET ======================================


            ////======================================== SNIPPET ========================================
            ////HOW TO WRITE THE ABOVE CODE USING A LAMBDA FUNCTION INSTEAD
            //int count = deck.Cards.Count(x => x.Face == Face.Ace); //THE LAMBDA SIGN '=>' CAN BE READ ALOUD SAYING "WHERE" OR "EVALUATE AND DO THE FOLLOWING THINGS TO EACH ITEM TO THE LEFT SIDE"
            //Console.WriteLine(count);

            ////USING A LAMBDA FUNCTION ON A LIST OF CUSTOM OBJECTS
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //TAKE THE NEW LIST OF CARDS AND FIND OUT WHERE THE FACE IS EQUAL TO KING AND MAP THEM TO A NEW LIST (SHOULD SHOW JUST KINGS IN THE LIST)

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            ////====================================== END SNIPPET ======================================


            //======================================== SNIPPET ========================================
            //USING A LAMBDA ON A LIST OF INTEGERS
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //------------ A FEW DIFFERENT LAMBDA FUNCTION EXAMPLES ON TYPE 'List<int>'
            //int sum = numberList.Sum();
            //int sum = numberList.Sum(x => x + 5); //ADDS MORE SPECIFICS TO WHAT TO DO WHEN ADDING
            //int sum = numberList.Max(); //GETS THE MAXIMUM VALUE IN THE LIST OF INTEGERS
            //int sum = numberList.Min(); //GETS THE MINIMUM VALUE IN THE LIST OF INTEGERS
            int sum = numberList.Where(x => x > 20).Sum(); //THIS CHAINS TWO LAMBDA FUNCTIONS TOGETER (BASICALLY CONCATENATES THEM). 'Where()' CREATES A NEW LIST

            Console.WriteLine(sum);
            //====================================== END SNIPPET ======================================


            //deck.Cards.


            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " OF " + card.Suit);
            //}
            //Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            Console.ReadLine();
        }      
    }
}




//====================================================================== OLD CODE SNIPPETS ======================================================================


//EXAMPLE OF A REFERENCE TYPE. EXAMPLE OFA TEACHER AND A STUDENT BOTH EDITING AN ESSAY ON 'GOOGLE DRIVE'
//OR ANY OTHER CLOUD BASED SERVICE WHERE THEY ARE ACTUALLY EDITING (REFERENCING) THE SAME EXACT COPY OF
//THE ESSAY. A VALUE TYPE WOULD BE 2 SEPERATE MEMORY LOCATIONS, LIKE SENDING AN EMAIL WHERE THERE ARE 2
//SEPERATE COPIES OF THE ESSAY.
//REFERENCE TYPES ARE: List<>, String, 'Card'
//VALUE TYPES ARE: int, bool, enum, DateTime

//REFERENCE AND VALUE TYPE EXAMPLE (SEE *** NOTE: BELOW )
//Card card1 = new Card(); 
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//*** NOTE:'Int32' OR 'int' IS A 'struct'. A 'struct' IS A CLASS THAT IS A VALUE TYPE. A 'struct' CAN'T BE 
//INHERITED THE DIFFERENCE BETWEEN A CLASS AND A STRUCT IS THAT A CLASS IS A REFERENCE TYPE AND A STRUCT IS 
//A VALUE TYPE THAT COULDN'T INHERIT. ANOTHER NOTE FOR A VALUE TYPE ('struct') IS THAT THEY CAN'T HAVE OR 
//BE ASSIGNED TO A VALUE OF 'null'. FINALLY, A GOOD WAY TO SHOW THIS DIFFERENCE IS TO EXECUTE THE ABOVE CODE 
//BOTH BEFORE AND AFTER CHANGING THE CLASS IN THE 'Card.cs' FILE FROM 'public class Card' AND THEN AGAIN OVER 
//TO 'public struct Card'. THE OUTPUT WHEN IT'S A 'class' (REFERENCE TYPE) WILL BE 'King'. THE OUTPUT WHEN IT 
//IS THEN CHANGED OVER TO A 'struct' (VALUE TYPE) WILL BE 'Eight'. 


//===============================================================================================================================================================


//Game game = new Twen\tyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Kirk";
//game += player; //SAME THING AS game = game + player;
//game -= player; //SAME THING AS game = game - player;



//===============================================================================================================================================================



////USING THE ENUM FROM 'Card' CLASS
//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = (int)Suit.Diamonds; //CASTING THE ENUM TO IT'S UNDERLYING DATA TYPE (INT). THIS COULD HAVE ALSO BEEN WRITTEN OUT AS 'int underlyingValue = Convert.ToInt32(underlyingValue)'
//Console.WriteLine(underlyingValue);



//===============================================================================================================================================================


//DaysofTheWeek day = DaysofTheWeek.Monday;

//public enum DaysofTheWeek
//{
//    Monday,
//    Tuesday, 
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday, 
//    Sunday
//}



//===============================================================================================================================================================