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
            //INSTANTIATE OBJECT FROM CLASS CONTSTRUCTOR 'Deck()'
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face.ToUpper() + " OF " + card.Suit.ToUpper());                
            }

            Console.WriteLine("\n\tTOTAL COUNT OF CARDS CREATED: " + deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
