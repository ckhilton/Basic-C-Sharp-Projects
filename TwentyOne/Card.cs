﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct /*class */ Card   //PUBLIC SIMPLY MEANS THAT IT'S AVAILABLE TO THE ENTIRE PROGRAM
                                    //WE CHANGED 'Card' FROM A 'class' TO A 'struct' BECAUSE A CARD
                                    //IS A SMALL VALUE AND ONCE YOU SET IT'S VALUE YOU DON'T REALLY WANT IT CHANGING IN A WEIRD WAY LIKE THE WAY A REFERNCE TYPE CAN BE CHANGED.
    {
        //EXAMPLE OF CREATING A CONSTRUCTOR FOR A DEFAULT VALUE
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    //DEFINE ENUM FOR 'Suit'. KEEPING IT HERE BECAUSE IT RELATES TO CARD CLASS
    public enum Suit
    {
        Clubs, //THESE CAN ALL HAVE THEIR OWN SEPERATE VALUES DECLARED, OTHERWISE THEY START IN ORDER AT "0" AND COUNT UPWARDS THE SAME AS A LIST OR AN ARRAY.
        Diamonds,
        Hearts,
        Spades
    }

    //DEFINE ENUM FOR 'Face' AS WELL. KEEPING IT HERE FOR SAME REASON AS ABOVE
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }


}