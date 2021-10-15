using System;

namespace _05_jumper
{
   public class Director
   {
      // Class-wide variables
      public Jumper _jumper = new Jumper();
      public UserService _userService = new UserService();
      public WordBank _wordBank = new WordBank();
      public DataValidationService _dataValidation = new DataValidationService();

      bool done = false;
      string letter;

      /// I don't know why this doesn't work, but we need to get this to work.
      // public const string _secretWord = _wordBank.GenerateWord(); 

      public void StartGame()
      {
         DoOutput();
         while (!done)
         {
            GetInputs();
            DoUpdates();
            DoOutput();
         }
      }

      /// Get all the needed from the user
      public void GetInputs()
      {
         letter = _userService.PromptLetter();
         while (!_dataValidation.ValidateLetter(letter))
         {
            _userService.ShowBadInputMessage();
            _userService.PromptLetter();
         }
      }

      /// Update the game state
      public void DoUpdates()
      {
         _jumper.
      }

      /// Do all the outputs for the game
      public void DoOutput()
      {
         _userService.DisplayParachute();

      }
   }
}
