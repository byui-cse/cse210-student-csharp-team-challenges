using System;

namespace _07_speed
{
    ///<summary>The difficulty class helps increase the difficulty of the game as 
    ///the player guesses words correctly. This class determines the speed of newly generated words
    /// and how many words there should be.</summary>
    class Difficulty
    {
        int _maxEnemies = 5;
        

        int _speed = 2;

        /// <summary>Do the logic to determine what the new difficulty of the game should be
        /// based on how many kills have happened so far.</summary>
        ///<param name="kills"><param>
        ///<return>none<return>
        public void updateDifficulty(int kills)
        {
            // Hardest phase
            if (kills >= 30)
            {
                _maxEnemies = 10;
                _speed = 4;
            }
            
            // intermediate phase
            else if (kills >= 20)
            {
                _maxEnemies = 8;
                _speed = 3;
            }

            // intermediate phase
            else if (kills >= 10)
            {
                _maxEnemies = 7;
                _speed = 2;
            }

            // starting phase with a slow introduction of words
            else if (kills <= 9)
            {
                if (kills >= 8)
                {
                    _maxEnemies = 5;
                    _speed = 1;
                }

                else if (kills >= 6)
                {
                    _maxEnemies = 4;
                    _speed = 1;
                }

                else if (kills >= 4)
                {
                    _maxEnemies = 3;
                    _speed = 1;
                }

                else if (kills >= 2)
                {
                    _maxEnemies = 2;
                    _speed = 1;
                }

                else
                {
                    _maxEnemies = 1;
                    _speed = 1;
                }

            }

            

            
        }

        /// <summary>get the speed value for newly generated words</summary>
        ///<return>int _speed<return>
        public int getSpeed()
        {
            return _speed;
        }

        /// <summary>get the value for how many enemies there should be</summary>
        ///<return>int _maxEnemies<return>
        public int getMaxEnemies()
        {
            return _maxEnemies;
        }

    }
}
