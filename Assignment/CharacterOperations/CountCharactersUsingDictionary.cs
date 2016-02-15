using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFunctions
{
    public class CountCharactersUsingDictionary
    {
        public static void CountCharactersInString(List<char> listOfCharacters)
        {
            Dictionary<char, int> characterCountDictionary = new Dictionary<char, int>();

            listOfCharacters.Sort();

            foreach (var character in listOfCharacters)
            {
                if (characterCountDictionary.ContainsKey(character))
                {
                    characterCountDictionary[character] += 1;
                }
                else
                {
                    characterCountDictionary.Add(character, 1);
                }

            }

            foreach (var character in characterCountDictionary)
            {
                Console.WriteLine(character.Key + " ==> " + character.Value);
            }
        }
    }
}
