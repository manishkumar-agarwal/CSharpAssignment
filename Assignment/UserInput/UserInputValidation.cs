using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserChoices;

namespace UserInputFunctions
{
    /// <summary>
    /// This class provides functionality to validate user inputs
    /// </summary>
    public class UserInputValidation
    {

        /// <summary>
        /// This method validates if a character input is valid
        /// </summary>
        /// <param name="startCharacter">character input to check for validity</param>
        /// <returns>Returns a flag indicating character is valid or not</returns>
        public static bool IsValidLetter(char inputCharacter)
        {
            bool isValidLetterFlag = true;
            if (!char.IsLetter(inputCharacter))
            {
                Console.WriteLine("Bad Input Character!!. Please try again with proper input");
                isValidLetterFlag = false;
            }

            return isValidLetterFlag;
        }


        /// <summary>
        /// This method checks if the Input User Choice is Valid
        /// </summary>
        /// <param name="userChoice">The UsersChoice inputted by the user</param>
        /// <returns>Returns a boolean flag to indicate if input UserChoice is valid</returns>
        public static bool IsValidUserChoice(UsersFunctionChoices userChoice)
        {
            bool isValidUserChoiceFlag = false;

            if (Enum.IsDefined(typeof(UsersFunctionChoices),userChoice))
                isValidUserChoiceFlag = true;

            return isValidUserChoiceFlag;

        }

        /// <summary>
        /// This method checks if the given input string has a valid value for further processing 
        /// </summary>
        /// <param name="stringToValidate"> This is the string value which needs to be validated</param>
        /// <returns> A flag indicating the string is valid or invalid</returns>
        public static bool IsValidString(string stringToValidate)
        {
            bool validStringFlag = true;
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
            bool isValidHeightOfTriangle = true;
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
            bool isStartEndCharacterValid = true;
            if (startCharacter > endCharacter)
            {
                Console.WriteLine($"\nStart Character {startCharacter} cannot be after the " +
                    $"End Character {endCharacter} .\n Bad Input!! Please retry with correct Inputs\n");

                isStartEndCharacterValid = false;
            }

            return isStartEndCharacterValid;
        }
    }
}
