using System;
using UserUtilities;

namespace TriangleFunctions
{
    /// <summary>
    /// This class defines methods to perform Triangle displays using characters
    /// </summary>
    public class CharacterTriangle
    {
        public static char[] CharacterArray;

        /// <summary>
        /// This method displays a triangular output using a character array 
        /// </summary>
        public static void PrintTriangularOutput()
        {
            var reverseCharacterArray = ExtendedUserUtilities.GenerateReverseCharacterArray(CharacterArray);
            Console.WriteLine("\n Below is the Output Triangle\n");
            Console.Write(CharacterArray);
            Console.WriteLine(reverseCharacterArray);

            for (int i = CharacterArray.Length - 1, j = 0;
                i >= 1 || j < reverseCharacterArray.Length - 2; i--, j++)
            {

                CharacterArray[i] = ' ';
                Console.Write(CharacterArray);
                Console.WriteLine(reverseCharacterArray);
                reverseCharacterArray[j] = ' ';

            }
        }
    }
}
