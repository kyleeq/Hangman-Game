using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Game
    {
        // member variables
        Player playerOne;
        Player playerTwo;
        string [] ScoreToPart;

        // constructor
        public Game()
        {
            
            ScoreToPart = new string [] {"nothing", "head", "left arm", "right arm", "left leg", "right leg" };
        }

        // member methods
    }
}
