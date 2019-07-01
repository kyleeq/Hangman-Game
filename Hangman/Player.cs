using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Player
    {
        // member variables
        public int currentScore;
        public int maxScore;
        public string name;


        // constructor
        public Player()
        {
            Console.WriteLine("Please enter your name and then press enter.");
            name = Console.ReadLine();
            currentScore = 0;
            maxScore = 6;
        }

        // member methods

    }
}
