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
            Deck deckNew = new Deck(); //INSTANTIATE AN OBJECT FROM THE CLASS 'Public Class Deck' AND NAMED IT 'deckNew' (EMPTY/NO VALUES ASSIGNED YET)
            deckNew = Shuffle(deckNew);

            foreach (Card card in deckNew.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //Console.WriteLine(deckNew.Cards[0].Face + " of " + deckNew.Cards[0].Suit);
            Console.WriteLine("TOTAL COUNT OF CARDS CREATED: " + deckNew.Cards.Count);
            Console.ReadLine();

        }

        //SHUFFLE THE DECK
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}



//================= OLD/SLOWER VERSION OF TYPING OUT CODE THAT WAS UPGRADED BY THE MORE EFFICIENT CODE THAT'S USED ABOVE =============

//deckNew.Cards = new List<Card>(); //MAKE THE PROPERTY 'Cards' INTO A BLANK LIST. REMEMBER THE CLASS "Public Deck" HAS ONLY 1 PROPERTY (WHICH IS A DATA TYPE OF LIST, CALLED 'Public List<Card> Cards')

//======== ...AND ALL OF THIS CODE WAS MOVED INTO THE CLASS 'Decks' FOR EASE OF CREATING NEW DECKS===============
//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";
//deckNew.Cards.Add(cardOne);