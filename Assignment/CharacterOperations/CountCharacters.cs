using System;
using System.Collections.Generic;
using System.Linq;
using UserUtilities;

namespace CharacterFunctions
{
    /// <summary>
    /// This class provides functionality to count distinct characters
    /// </summary>
    public class CountCharacters
    {

        public static CharacterOperationType characterOperationType = CharacterOperationType.CaseSensitive;

        /// <summary>
        /// This method is the API method invoked to get the counts of characters in string
        /// </summary>
        /// <param name="userString">user input String to provide character counts</param>
        public static void CountCharacterInString( string userString)
        {
            IEnumerable<char> distinctCharactersList = ExtendedUserUtilities.GenerateDistinctCharacterList
                                                                            (userString, characterOperationType);

            CountCharacterOccurancesInString(distinctCharactersList, userString);

        }

   

         /// <summary>
        /// This method provides a count of the distinct characters in the string 
        /// </summary>
        /// <param name="distinctCharactersList">An IEnumerable List of distinct characters in String</param>
        /// <param name="userString">user input String to provide character counts</param>
        private static void CountCharacterOccurancesInString(IEnumerable<char> distinctCharactersList, string userString)
        {

            List<char> listOfCharacters = userString.ToList();

            Console.WriteLine("Below is the distinct " + characterOperationType +
                " character count for the string: " + userString);

            DisplayDistinctCharacterCounts(distinctCharactersList, listOfCharacters);
        }

        /// <summary>
        /// This method display the distinct character counts in the list
        /// </summary>
        /// <param name="distinctCharactersList">List of distinct Characters</param>
        /// <param name="listOfCharacters">List of all characters in the string</param>
        private static void DisplayDistinctCharacterCounts(IEnumerable<char> distinctCharactersList, List<char> listOfCharacters)
        {
            foreach (var distinctCharacter in distinctCharactersList)
            {
                var charCount = 0;

                foreach (var character in listOfCharacters)
                {
                    if ((distinctCharacter == character) ||
                        (characterOperationType == CharacterOperationType.CaseInsensitive &&
                        Char.ToLower(distinctCharacter) == character))
                    {
                        charCount++;
                    }
                }

                Console.WriteLine("{0} --> {1}", distinctCharacter, charCount);
                RemoveProcessedCharactersFromList(listOfCharacters, distinctCharacter, charCount);
            }
        }

        /// <summary>
        /// This method removes those characters which have been processed from the list.
        /// </summary>
        /// <param name="listOfCharacters"> A List of characters</param>
        /// <param name="distinctCharacter">The distinct character for which processing is completed</param>
        /// <param name="charCount">The character occurances for distinct character in the list</param>
        private static void RemoveProcessedCharactersFromList(List<char> listOfCharacters,
                                                                char distinctCharacter, int charCount)
        {
            var removeOperationFlag = true;

            for (int i = 0; i < charCount && removeOperationFlag != false; i++)
                removeOperationFlag = listOfCharacters.Remove(distinctCharacter);

            if(characterOperationType == CharacterOperationType.CaseInsensitive)
            {
                removeOperationFlag = true;
                for (int i = 0; i < charCount && removeOperationFlag != false; i++)
                    listOfCharacters.Remove(Char.ToLower(distinctCharacter));

            }
            
        }
    }
}
