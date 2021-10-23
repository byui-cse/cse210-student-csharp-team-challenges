using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class UserService
    {
        /// <Summary>
        /// Asks for the player names. Insert them into a list. Returns input.
        /// </Summary>
        public List<string> getName()
        {
            string name1;
            string name2;

            Console.Write("Enter a name for player 1: ");
            name1 = Console.ReadLine();
            Console.Write("Enter a name for player 2: ");
            name2 = Console.ReadLine();

            List<string> playerNames = new List<string>
            {
                name1, name2
            };

            return playerNames;
            
        }

        /// <Summary>
        /// Asks for the player's guess. Validates the guess. Returns input (if valid).
        /// </Summary>
        public string getGuess()
        {
             while(true){
                Console.WriteLine("What is your guess? ");
                string input = Console.ReadLine();

                if (input.Length == 4)
                {
                    
                    if (int.TryParse(input, out _))
                    {
                        return input;
                    }
                }

                Console.WriteLine("Please choose only FOUR numbers.");
            }  

        }

            /// <Summary>
            /// Display the current turn.
            /// </Summary>
            public void displayTurn(string playerTurn)
            {
                
              Console.WriteLine(playerTurn);

            }
                  
    }
}