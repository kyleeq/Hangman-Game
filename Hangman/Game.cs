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
        string guessedWord;


        // constructor
        public Game()
        {
            
            ScoreToPart = new string [] {"nothing", "head", "body", "left arm", "right arm", "left leg", "right leg" };
        }

        // member methods
        public void WelcomeDescriptionPrompt()
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.ReadLine();
            Console.WriteLine("Directions: \nThis game requires two players.\n"
                + "Player one will input a word and player two will guess what letters are in that word.\n"
                + "If player two's guess is correct, the letter will be appear in the slot(s) it belongs in.\n"
                + "If the guess is incorrect, an appendage will be added to the hangman character.\n"
                + "To win the game, player two must guess ALL the letter's in player one's selected word BEFORE the hangman every appendage.");
        }
    }
}
