using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //CREATE A CONSTRUCTOR FOR THE CLASS 'Deck'
        public Deck() //METHOD WITHIN THE PUBLIC CLASS 'Deck' CALLED 'Deck()'
        {            
            Cards = new List<Card>(); //INSTANTIATE PROPERTY OF 'Cards' AS AN EMPTY LIST OF CARDS (ALWAYS HAVE TO CREATE A NEW LIST)

            //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Suits'
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Faces'
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            //FOR EVERY 'face' IN 'Faces' AND FOR EVERY 'suit' IN 'SUITS' WE...
            foreach (string face in Faces)
            {
                //CREATE A NEW CARD DURING EACH LOOP THAT ASSIGNS THE 'Suit' VALUE THE PROPERTY OF 'suit' AND THE 'face' VALUE TO THE PROPERTY OF 'face'
                //NESTED LOOP
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        //SHUFFLE THE DECK
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
        }
    }
}
