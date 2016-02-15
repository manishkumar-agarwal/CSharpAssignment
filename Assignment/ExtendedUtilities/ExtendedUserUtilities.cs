using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserUtilities
{
    /// <summary>
    /// This class provides extended utilities for performing operations
    /// </summary>
    public class ExtendedUserUtilities
    {

        /// <summary>
        /// This method generates a character array based on the Start and End Characters.
        /// </summary>
        /// <param name="startCharacter">Starting Character to gernarte character Array</param>
        /// <param name="endCharacter">Ending Character for generating Character Array</param>
        /// <returns>Returns a character array with all character from 
        /// StartCharacter to endCharacter, both included</returns>
        public static char[] GenerateCharacterArray(char startCharacter, char endCharacter)
        {
            int charArraySize = (endCharacter - startCharacter) + 1;

            char[] characterArray = new char[charArraySize];
            int arrayIndex = 0;
            for (char character = startCharacter; character <= endCharacter; character++)
            {
                characterArray[arrayIndex] = character;
                arrayIndex++;
            }

            return characterArray;
        }



        /// <summary>
        /// This method generates the reverse of a character array by excluding the last character
        /// </summary>
        /// <param name="charArray">Input of the character array to reverse</param>
        /// <returns></returns>
        public static char[] GenerateReverseCharacterArray(char[] charArray)
        {
            char[] reverseCharacterArray = new char[charArray.Length - 1];

            //The below loop prepares the reverse of the character array
            for (int i = 0, j = charArray.Length - 2;
                i < reverseCharacterArray.Length && j >= 0; i++, j--)
            {
                reverseCharacterArray[i] = charArray[j];
            }

            return reverseCharacterArray;
        }


        /// <summary>
        /// This method returns the IEnumerable list of characters from the string 
        /// based on the type of operation to be performed
        /// </summary>
        /// <param name="userString">user input String to provide character counts</param>
        /// <param name="characterOperationType">The Type of operation to be performed.</param>
        /// <returns></returns>
        public static IEnumerable<char> GenerateDistinctCharacterList(string userString,
                                CharacterOperationType characterOperationType = CharacterOperationType.CaseSensitive)
        {
            IEnumerable<char> distinctCharactersList;
            if (characterOperationType == CharacterOperationType.CaseSensitive)
            {
                distinctCharactersList = userString.Distinct<char>();
            }
            else
            {
                distinctCharactersList = userString.ToUpper().Distinct<char>();
            }

            return distinctCharactersList;
        }

    }
}
