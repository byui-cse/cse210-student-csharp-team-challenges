using System;

namespace _06_mastermind
{
    class Code
    {
        string _secret;


        /// <summary>
        /// Generates the secret code that the users will try and guess
        /// </summary>
        /// <returns>secret number in string form</returns>
        private void generateSecret()
        {
            Random randomGenertor = new Random();

            int secretNumber = randomGenertor.Next(1000, 10000);

            _secret = secretNumber.ToString();
        }
        /// <summary>
        /// Deteremines wheter or not the guess is correct
        /// </summary>
        /// <returns>If correct, returns true. if incorrect, returns false.</returns>
        public bool isSecret(string guess)
        {
            if (guess == _secret)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Displays the hint for the user. x if the number is corect and in the right place. o if the number is in the secret code but incorrect location. * if number is not in the secret at all.
        /// </summary>
        /// <returns>Returns the hint built with the indicated symbols.</returns>
        public string getHint(string guess)
        {
            string hint = "";
            
            for (int i = 0; i < _secret.Length; i++)
            {
                if (_secret[i] == guess[i])
                {
                    hint += "x";
                }
                else if (_secret[i] != guess[i])
                {
                    hint += "*";
                }
                else if (_secret.Contains(guess[i]))
                {
                    hint += "o";
                }
            }
            return hint;
        }
    }
}