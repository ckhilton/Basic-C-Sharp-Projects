using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        //CREATE A CONSTRUCTOR FOR THE CLASS 'Deck'
        public Deck() //METHOD WITHIN THE PUBLIC CLASS 'Deck' CALLED 'Deck()'
        {            
            Cards = new List<Card>(); //INSTANTIATE PROPERTY OF 'Cards' AS AN EMPTY LIST OF CARDS (ALWAYS HAVE TO CREATE A NEW LIST)

            //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Suits'
            List<string> Suits = new List<string>() { "CLUBS", "HEARTS", "DIAMONDS", "SPADES" };

            //INSTANTIATE NEW LIST WITH DEFAULT VALUES FOR 'Faces'
            List<string> Faces = new List<string>() { "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "JACK", "QUEEN", "KING", "ACE" };


            for (int i = 0; i < 13; i++) //THIS FOR-LOOP REPEATS 13 TIMES
            {
                for (int j = 0; j < 4; j++) // THIS NESTED FOR-LOOP THAT WILL GO THROUGH EACH OF THE 13 FACES 4 TIMES (ONCE FOR EACH OF THE DIFFERENT 4 SUITS) FOR A TOTAL OF 52 TIMES, AND ADDING EACH REPETITION OF THE LOOP AS A CARD TO CREATE THE DECK.
                {
                    Card card = new Card(); //INSTANTIATES A NEW BLANK 'Card' EACH TIME AROUND THE LOOP (52 TIMES AROUND)
                    card.Face = (Face)i; //TO CAST TO A DATA TYPE, PUT THE DATA TYPE YOUR CASTING TO, INSIDE OF THE PARENTHESES. J IS AN INTEGER IN THIS CASE (CASTING TO AN INTEGER).
                    card.Suit = (Suit)j; //CASTING TO DATA TYPE 'Suit' WHICH IS A BASE DATA TYPE OF THE INTEGER VALUE OF 'i' IN THIS CASE
                    Cards.Add(card); //ADDS THE CARD EACH TIME AROUND TO THE DECK
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


//namespace TwentyOne
//{
//    public class Deck
//    {
//        //CREATE A CONSTRUCTOR FOR THE CLASS 'Deck'
//        public Deck() //METHOD WITHIN THE PUBLIC CLASS 'Deck' CALLED 'Deck()'
//        {
//            Cards = new List<Card>(); //INSTANTIATE PROPERTY OF 'Cards' AS AN EMPTY LIST OF CARDS (ALWAYS HAVE TO CREATE A NEW LIST)

//            //FOR EVERY 'face' IN 'Faces' AND FOR EVERY 'suit' IN 'SUITS' WE...
//            foreach (string face in Faces)
//            {
//                //CREATE A NEW CARD DURING EACH LOOP THAT ASSIGNS THE 'Suit' VALUE THE PROPERTY OF 'suit' AND THE 'face' VALUE TO THE PROPERTY OF 'face'
//                //NESTED LOOP
//                foreach (string suit in Suits)
//                {
//                    Card card = new Card();
//                    card.Suit = suit;
//                    card.Face = face;
//                    Cards.Add(card);
//                }
//            }
//        }

//        public List<Card> Cards { get; set; }

//        //SHUFFLE THE DECK FUNCTION/METHOD
//        public void Shuffle(int times = 1)
//        {
//            for (int i = 0; i < times; i++)
//            {
//                List<Card> TempList = new List<Card>();
//                Random random = new Random();

//                while (Cards.Count > 0)
//                {
//                    int randomIndex = random.Next(0, Cards.Count);
//                    TempList.Add(Cards[randomIndex]);
//                    Cards.RemoveAt(randomIndex);
//                }
//                this.Cards = TempList;
//            }
//        }
//    }
//}

