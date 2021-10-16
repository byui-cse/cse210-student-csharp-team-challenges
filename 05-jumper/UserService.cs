using System;

namespace _05_jumper
{
    /// <Summary>
    /// 
    /// </Summary>
    class UserService
    {

        /// <Summary>
        /// Asks the user if he wants to play again. Validates the input. Returns answer.
        /// </Summary>
        public bool GetPlayAgain()
        {
            while(true){
                Console.WriteLine("Do you want to play again?(Y / N): ");
            
                string input = Console.ReadLine().ToLower();

                if (input.Length == 1)
                {
                    if (input == "y")
                    {
                        return true;
                    }
                    if (input == "n")
                    {
                        return false;
                    }
                }

                Console.WriteLine("Please choose Y or N");
            }  
        }
        /// <Summary>
        /// 
        /// </Summary>
        public void DisplayBoard(string word, string jumper)
        {

        }

        /// <Summary>
        /// Asks the user for a letter. Validates input. Returns input (if valid).
        /// </Summary>
        public char GetGuess()
        {
            while(true){
                Console.WriteLine("Choose one letter: ");
            
                string input = Console.ReadLine();

                if (input.Length == 1)
                {
                    char checkChar = char.Parse(input);

                    if (char.IsLetter(checkChar))
                    {
                        return checkChar;
                    }
                }

                Console.WriteLine("Please choose just ONE letter.");
            }  
        }

        /// <Summary>
        /// 
        /// </Summary>
        private string FormatWord(string baseWord)
        {
            // computer
            string output = "";

            foreach (char letter in baseWord){
                output += letter + " ";
                
            }

            return output;
        }
    }
}