using System;
using UserChoices;

namespace UserInputFunctions
{
    /// <summary>
    /// This class provides functionality to accept user inputs
    /// </summary>
    public class UserInputGathering
    {
        #region methods
        public static char GetCharacterInput()
        {

            var characterUnicodeValue = Console.ReadKey().KeyChar;
            var character = char.ToUpperInvariant(characterUnicodeValue);
            return character;
        }


        public static char GetCharacterInput(string displayString)
        {
            Console.WriteLine(displayString);
            return GetCharacterInput();
        }


        public static string GetStringInput()
        {
            Console.WriteLine("Please Enter a String for Operation");
            var userInputString = Console.ReadLine();
            return userInputString;
        }


        public static UsersFunctionChoices GetUsersChoice()
        {
            var userChoice = (UsersFunctionChoices)(Int32.Parse(Console.ReadLine()));
            return userChoice;
        }


        public static int GetIntergerInput(string displayString = "\nPlease enter an integer value ")
        {
            Console.WriteLine(displayString);
            return Int32.Parse(Console.ReadLine());
        }

        #endregion methods
    }
}
