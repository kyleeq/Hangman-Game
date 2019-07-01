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

        public string[] BodyParts;
        public int BodyPartNum;
        public string word;
        public string[] wordArray; 
        public string guessedWord;
        public string[] alphabet;


        // constructor
        public Game()
        {
            BodyParts = new string[] {"nothing", "head", "body", "left arm", "right arm", "left leg", "right leg" };
            alphabet = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            BodyPartNum = 0;
        }

        // member methods
        public void KickOff()
        {
            WelcomeDescriptionPrompt();
            Console.ReadLine();
            CreatePlayers();
            WordPrompt();
            CreateWordArray(word);
            for (int i = 0; i < 6; i++)
            {
                LetterDeterminator(GuessALetter(), word);
            }
        }
        public void WelcomeDescriptionPrompt()
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.ReadLine();
            Console.WriteLine("Directions: \nThis game requires two players.\n"
                + "Player one will input a word and player two will guess what letters are in that word.\n"
                + "If player two's guess is correct, the letter will be appear in the slot(s) it belongs in.\n"
                + "If the guess is incorrect, an appendage will be added to the hangman character.\n"
                + "To win the game, player two must guess ALL the letter's in player one's selected word BEFORE \n"
                + "the hangman every appendage.");
        }
        public void CreatePlayers()
        {
            Console.WriteLine("Player One:");
            playerOne = new Player();
            Console.WriteLine("Player Two:");
            playerTwo = new Player();
        }
        public string WordPrompt()
        {
            Console.WriteLine(playerOne.name + " enter a word you would like " + playerTwo.name + " to guess");
            word = Console.ReadLine();
            
            return word;
        }
        public void CreateWordArray(string word)
        {
            wordArray = new string[word.Count()];
            for (int i = 0; i < wordArray.Count(); i++)
            {
                if (wordArray[i] == null)
                {
                    wordArray[i] = "_";
                }
            }
        }
        public string GuessALetter()
        {
            Console.WriteLine(playerTwo + " guess a letter");
            string letter = Console.ReadLine().ToLower();
            if (letter.Count() != 1)
            {
                GuessALetter();
            }
            return letter;
        }
        public void LetterDeterminator(string letter, string word)
        {
            if (word.Contains(letter))
            {
                foreach (string item in alphabet)
                {

                    if (item == letter)
                    {
                        letter = null;
                    }
                }
                Console.WriteLine("Heyooo! " + letter + " is in " + playerOne + "'s word!");
            }
            else
            {
                BodyPartNum++;
                Console.WriteLine("Big oof. " + playerOne + "'s word does not contain that letter. Hangman now has a " + BodyParts[BodyPartNum]);
            }
        }
        public void CompareWords()
        {
            Console.WriteLine(wordArray);
        }
        public void FinalMenu()
        {
            Console.WriteLine("Would you like to play again? Please type 'restart' to play again and 'quit' to exit the game");
            string UserInput = Console.ReadLine().ToLower();

            switch (UserInput)
            {
                case "restart":
                    KickOff();
                    break;
                case "quit":
                    break;
            }
        }
    }
}