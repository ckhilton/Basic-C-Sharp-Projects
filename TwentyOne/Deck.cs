using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //CREATE A PUBLIC METHOD/FUNCTION WITHIN THE CLASS CALLED 'public Deck()'
        {
            //CREATE A CONSTRUCTOR FOR THE CLASS 'Deck'
            Cards = new List<Card>(); //INSTANTIATE PROPERTY OF 'Cards' AS AN EMPTY LIST OF CARDS (ALWAYS HAVE TO CREATE A NEW LIST)

            List<string> Suits = new List<string>() //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Suits'
            {
                "Clubs", "Hearts", "Diamonds", "Spades" 
            };
            List<string> Faces = new List<string>() //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Faces'
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //FOR EVERY 'face' in 'Faces' WE 
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
    }
}

//------------- OLD CODE THAT WAS UPGRADED TO THE NEW, MORE EFFICIENT CODE ABOVE -----------
//Cards = new List<Card>(); //INSTANTIATE A NEW EMPTY LIST OBJECT OF CARDS
//Card cardOne = new Card(); //INSTANTIATE NEW CARD OBJECT (EMPTY PROPERTY VALUES) CALLED 'cardOne'
//cardOne.Face = "Two"; //GIVE THE 'Face' PROPERTY OF 'cardOne' A DEFAULT VALUE OF "Two;"
//cardOne.Suit = "Hearts"; //GIVE THE 'Suit' PROPERTY OF 'cardOne' A DEFAULT VALUE OF "Hearts;"
//Cards.Add(cardOne); //ADD 'cardOne' TO THE 'Cards' LIST