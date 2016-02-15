using System;
using UserInputFunctions;
using UserUtilities;

namespace UserInterfaceFunctions
{
    class UserInterfaceSetupFunctions
    {

        /// <summary>
        /// This method prompts user for height of triangle
        /// </summary>
        internal static int SetHeightOfTriangle()
        {
            var heightOfTriangle = UserInputGathering.GetIntergerInput("Please enter the height of star triangle");

            if (UserInputValidation.IsValidHeightofTriangle(heightOfTriangle) == false)
            {
                throw new InvalidOperationException(" ");
            }

            return heightOfTriangle;

        }

        /// <summary>
        /// This method accepts and validates the String Input
        /// </summary>
        /// <returns>Returns the String inputted by User</returns>
        internal static string GetUserInputString()
        {
            var userInputString = UserInputGathering.GetStringInput();
            if (!UserInputValidation.IsValidString(userInputString))
            {
                throw new InvalidOperationException(" ");

            }

            return userInputString;
        }

        /// <summary>
        /// This method sets the character aray to print triangle by prompting user for String
        /// </summary>
        /// <returns>returns a character array from user inputted String</returns>
        internal static char[] SetCharacterArrayUsingString()
        {
            var userInput = GetUserInputString();

            return userInput.ToCharArray();
        }

    /// <summary>
    /// This method forms the character aray to print triangle by prompting user for Start and End Characters
    /// </summary>
    /// <returns>returns a character array from start character to end character</returns>
    internal static char[] SetCharacterArrayUsingStartEndCharacters()
        {
            var startCharacter = GetCharacterInput("\nPlease enter an input start character : ");

            var endCharacter = GetCharacterInput("\nPlease enter an input end character : ");

            UserInputValidation.ValidateStartAndEndCharacter(startCharacter, endCharacter);

            var characterArray = ExtendedUserUtilities.GenerateCharacterArray(startCharacter, endCharacter);

            return characterArray;

        }

        /// <summary>
        /// This method accepts a character input and validates if it is a letter.
        /// </summary>
        /// <param name="descriptionString">Description String for display</param>
        /// <returns>character Input</returns>
        private static char GetCharacterInput(string descriptionString)
        {
            var character = UserInputGathering.GetCharacterInput(descriptionString);
            if (!UserInputValidation.IsValidLetter(character))
                throw new InvalidOperationException(" ");

            return character;
        }
    }
}
