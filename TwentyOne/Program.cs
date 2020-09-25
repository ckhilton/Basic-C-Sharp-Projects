using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        //***RULES TO A METHOD/FUNCTION: ACCESS MODIFIER, RETURN TYPE 'voic', A NAME 'Main', PARAMETERS '(string[] args), METHODS ALSO HAVE TO BE PART OF A CLASS. IF...
        //...A METHOD IS BEING USED WITHOUT FIRST CREATING AN OBJECT OF THAT CLASS THEN IT HAS TO BE MARKED AS 'static'
        static void Main(string[] args) //***NOTE: AN ACCESS MODIFIER EXAMPLE IS 'public', WHICH WOULD GIVE ACCESS TO THE FUNCTION FROM THE REST OF THE PROGRAM
        {
            Deck deck = new Deck(); //INSTANTIATE AN OBJECT FROM THE CLASS 'Public Class Deck' AND NAMED IT 'deckNew' (EMPTY/NO VALUES ASSIGNED YET)
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); //'out timesShuffled' SENDS THE OUTPUT TO 'int timesShuffled = 0' (ABOVE) INSTEAD OF ASSIGNING IT TO 'deck'.

            /*deck = Shuffle(deck, 3); *///THIS JUST ADDS A PARAMETER FOR THE NUMBER OF TIMES TO SHUFFLE THE DECK BASED ON THE OLD/NOT USED/LESS EFFICIENT CODE (THAT WAS COMMENTED OUT) RIGHT BELOW THE SHUFFLE DECK FUNCTION.
            /*deck = Shuffle(deck: deck, times: 3);*/ //THIS IS A NAMED PARAMETER. IT'S THE EXACT SAME AS THE COMMENTED OUT CODE IMMEDIATELY ABOVE THIS LINE, BUT IT MAKES THE CODE EASIER TO READ

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());                
            }

            //Console.WriteLine(deckNew.Cards[0].Face + " of " + deckNew.Cards[0].Suit);
            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            Console.WriteLine("\n\tTIMES SHUFFLED: {0}", timesShuffled);
            Console.ReadLine();

        }

        //SHUFFLE THE DECK
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times) //THIS GOT COMMENTED OUT BECAUSE WE USED A DEFAULT PARAMETER TO DO THE SAME THING ON THE METHOD ABOVE INSTEAD
        //{
        //    for (int i = 0; i < times; i++ )
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}



//================= OLD/SLOWER VERSION OF TYPING OUT CODE THAT WAS UPGRADED BY THE MORE EFFICIENT CODE THAT'S USED ABOVE =============

//deckNew.Cards = new List<Card>(); //MAKE THE PROPERTY 'Cards' INTO A BLANK LIST. REMEMBER THE CLASS "Public Deck" HAS ONLY 1 PROPERTY (WHICH IS A DATA TYPE OF LIST, CALLED 'Public List<Card> Cards')

//======== ...AND ALL OF THIS CODE WAS MOVED INTO THE CLASS 'Decks' FOR EASE OF CREATING NEW DECKS===============
//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";
//deckNew.Cards.Add(cardOne);