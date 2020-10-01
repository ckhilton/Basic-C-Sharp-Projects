using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player //NOTE* WE COULD MAKE THIS GENERIC BY MAKING THE CLASS 'Player<T>'. THIS WILL MAKE THE CLASS MORE ABSTRACT (IN ANY List<T> 'T' ACTUALLY STANDS FOR 'TYPE' IN 'DATA TYPE', SO IT GIVES US OPTIONS TO PASS DIFFERENT DATA TYPES INTO LISTS FROM THIS A MORE ABSTRACT/GENERIC CLASS).
    {
        public List<Card> Hand { get; set; } //*NOTE THIS WOULD ALSO HAVE TO BE 'List<T>' IN ORDER TO MAKE THE LIST 'Hand' FROM THIS CLASS MORE USEABLE (I.E. MAYBE FROM ANOTHER DATA TYPE LIKE 'int' OR ANY OTHER CLASS WITH A DIFFERENT DATA TYPE THAN 'List<Card>'
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
