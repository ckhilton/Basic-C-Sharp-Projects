using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //PUBLIC SIMPLY MEANS THAT IT'S AVAILABLE TO THE ENTIRE PROGRAM
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} OF {1}", Face, Suit);
        }
    }

    public enum Suit
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum Face
    {
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        ACE
    }
}


//public class Card //PUBLIC SIMPLY MEANS THAT IT'S AVAILABLE TO THE ENTIRE PROGRAM
//{
//    //EXAMPLE OF CREATING A CONSTRUCTOR FOR A DEFAULT VALUE
//    public Card()
//    {
//        Suit = "Spades";
//        Face = "Two";
//    }
//    public string Suit { get; set; }
//    public string Face { get; set; }
//}