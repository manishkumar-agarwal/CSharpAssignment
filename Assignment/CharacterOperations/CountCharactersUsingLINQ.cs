using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserUtilities;

namespace CharacterFunctions
{
    /// <summary>
    /// This class performs distinct character count using LINQ query
    /// </summary>
    public class CountCharactersUsingLINQ
    {

        public static void CountCharactersInString(List<char> listOfCharacters)
        {
            listOfCharacters.Sort();

            var distinctCharacterQuery = from character in listOfCharacters
                            group character by character;

            foreach (var distinctCharacter in distinctCharacterQuery)
            {
                Console.WriteLine(distinctCharacter.Key + "==> " + distinctCharacter.Count());
            }

        }
    }
}
