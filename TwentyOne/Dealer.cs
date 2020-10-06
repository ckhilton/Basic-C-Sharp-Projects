using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } //A DEALER IS NOT A TYPE OF DECK, BUT RATHER 'has a' DECK. IN OTHER WORDS, IF IT'S AN 'is a' RELATIONSHIP (i.e. A 'Dealer' "is a" 'Deck'), THEN INHERIT THE CLASS. IF IT 'has a' RELATIONSHIP (i.e. A 'Dealer' "has a" 'Deck'), THEN INCLUDE IT AS A CLASS PROPERTY
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
