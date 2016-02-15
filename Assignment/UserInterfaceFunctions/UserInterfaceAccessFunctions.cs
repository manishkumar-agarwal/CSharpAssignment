using TriangleFunctions;
using CharacterFunctions;
using UserUtilities;

namespace UserInterfaceFunctions
{
    public class UserInterfaceAccessFunctions
    {
        /// <summary>
        /// This method prints a triangle by taking String input from user
        /// </summary>
        public static void PrintTriangleUsingString()
        {
            CharacterTriangle.CharacterArray = UserInterfaceSetupFunctions.SetCharacterArrayUsingString();
            CharacterTriangle.PrintTriangularOutput();
        }

        /// <summary>
        /// This method prints a triangle by taking Start and End character input from user
        /// </summary>
        public static void PrintTriangleUsingStartEndCharacters()
        {
            CharacterTriangle.CharacterArray = UserInterfaceSetupFunctions.SetCharacterArrayUsingStartEndCharacters();
            CharacterTriangle.PrintTriangularOutput();
        }

        /// <summary>
        /// This method counts the disticnt characters in a case senstive manner
        /// </summary>
        public static void CountCharactersCaseSensitive()
        {
            var listOfCharacters = UserInterfaceSetupFunctions.GetListOfCharacters(CharacterOperationType.CaseSensitive);
            //CountCharactersUsingLINQ.CountCharactersInString(listOfCharacters);
            CountCharactersUsingDictionary.CountCharactersInString(listOfCharacters);
        }

        /// <summary>
        /// This method counts the disticnt characters in a case insenstive manner
        /// </summary>
        public static void CountCharactersCaseInSensitive()
        {
            var listOfCharacters = UserInterfaceSetupFunctions.GetListOfCharacters(CharacterOperationType.CaseInsensitive);
            //CountCharactersUsingLINQ.CountCharactersInString(listOfCharacters);
            CountCharactersUsingDictionary.CountCharactersInString(listOfCharacters);
        }

        /// <summary>
        /// This method Prints the Star Triangle
        /// </summary>
        public static void PrintStarTriangle()
        {
            StarTriangle.HeightOfTriangle = UserInterfaceSetupFunctions.SetHeightOfTriangle();
            StarTriangle.PrintStarTriangle();
        }
    }
}
