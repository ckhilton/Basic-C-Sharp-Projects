using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //LOGGING TO A FILE: APPENDS THE FILE "log.txt" AND ADDS ANY CARDS DELT EVERY TIME THE DEALER DEALS
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\desktop\log.txt", true)) //'true' TELLS THE PROGRAM TO APPEND THE TEXT TO THE END OF A FILE. IF IT SAID FALSE, IT WOULD CREATE A NEW FILE
            {
                file.WriteLine(DateTime.Now); //GIVES EACH ENTRY IN THE LOG A TIMESTAMP
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
