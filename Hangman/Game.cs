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
        Player playerOne; // supplies the word 
        Player playerTwo; // guesses the letters in playerOne's word
        public string [] BodyParts;
        public string guessedWord;


        // constructor
        public Game()
        {
            BodyParts = new string [] {"nothing", "head", "body", "left arm", "right arm", "left leg", "right leg" };
            playerOne = new Player();
            playerTwo = new Player();
        }

        // member methods
        public void KickOff()
        {
            WelcomeDescriptionPrompt();
            Console.ReadLine();
            CreatePlayers();
        }
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
        public void CreatePlayers()
        {
            Console.WriteLine("Player one, please enter your name and then press enter when you're finished.");
            playerOne = new Player();
            playerOne.name = Console.ReadLine();
            Console.WriteLine("Player two, please enter your name and then press enter when you're finished.");
            playerTwo = new Player();
            playerTwo.name = Console.ReadLine();
        }
    }
}
