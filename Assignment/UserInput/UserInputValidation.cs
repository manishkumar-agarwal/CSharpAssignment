using System;
using UserChoices;

namespace UserInputFunctions
{
    /// <summary>
    /// This class provides functionality to validate user inputs
    /// </summary>
    public class UserInputValidation
    {

        #region methods

        public static bool IsValidLetter(char inputCharacter)
        {
            var isValidLetterFlag = true;

            if (!char.IsLetter(inputCharacter))
            {
                Console.WriteLine("Bad Input Character!!. Please try again with proper input");
                isValidLetterFlag = false;
            }

            return isValidLetterFlag;
        }


        public static bool IsValidUserChoice(UsersFunctionChoices userChoice)
        {
            var isValidUserChoiceFlag = false;

            if (Enum.IsDefined(typeof(UsersFunctionChoices),userChoice))
                isValidUserChoiceFlag = true;

            return isValidUserChoiceFlag;

        }


        public static bool IsValidString(string stringToValidate)
        {
            var validStringFlag = true;

            if (String.IsNullOrWhiteSpace(stringToValidate))
            {
                Console.WriteLine("Empty String Passed, Please Provide Proper Input");
                validStringFlag = false;
            }
            return validStringFlag;
        }

        /// <summary>
        /// This method validates if an input Height of Triangle is valid
        /// </summary>
        /// <param name="startCharacter">character input to check for validity</param>
        /// <returns>Returns a flag indicating character is valid or not</returns>
        public static bool IsValidHeightofTriangle(int heightOfTriangle)
        {
            var isValidHeightOfTriangle = true;
            if (heightOfTriangle == 0)
            {
                Console.WriteLine("Cannot draw traingle of height Zero");
                isValidHeightOfTriangle = false;
            }

            return isValidHeightOfTriangle;
        }



        /// <summary>
        /// This method validates if the start character and end character combination is valid
        /// </summary>
        /// <param name="startCharacter">start character</param>
        /// <param name="endCharacter">end character</param>
        /// <returns>Returns a flag to indicate the start character and end character combination is valid</returns>
        public static bool ValidateStartAndEndCharacter(char startCharacter, char endCharacter)
        {
            var isStartEndCharacterValid = true;
            if (startCharacter > endCharacter)
            {
                Console.WriteLine($"\nStart Character {startCharacter} cannot be after the " +
                    $"End Character {endCharacter} .\n Bad Input!! Please retry with correct Inputs\n");

                isStartEndCharacterValid = false;
            }

            return isStartEndCharacterValid;
        }

        #endregion methods
    }
}
