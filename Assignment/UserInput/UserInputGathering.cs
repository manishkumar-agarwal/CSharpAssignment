using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserChoices;

namespace UserInputFunctions
{
    /// <summary>
    /// This class provides functionality to accept user inputs
    /// </summary>
    public class UserInputGathering
    {

        /// <summary>
        /// This method gets the user to enter a Character Input
        /// </summary>
        /// <returns>Returns the character inputted by user </returns>
        public static char GetCharacterInput()
        {

            char characterUnicodeValue = Console.ReadKey().KeyChar;
            char character = char.ToUpperInvariant(characterUnicodeValue);
            return character;
        }


        /// <summary>
        /// This method displays the message and gets the user to enter a Character Input
        /// </summary>
        /// <param name="displayString"> String to be displayed on Console</param>
        /// <returns>Returns the character inputted by user</returns>
        public static char GetCharacterInput(string displayString)
        {
            Console.WriteLine(displayString);
            return GetCharacterInput();
        }


        /// <summary>
        /// This method accepts a String as input from the Console
        /// </summary>
        /// <returns>Returns the string inputted by User on the Console</returns>
        public static string GetStringInput()
        {
            Console.WriteLine("Please Enter a String for Operation");
            string userInputString = Console.ReadLine();
            return userInputString;
        }

        /// <summary>
        /// This method gets the users choice of activity to be performed
        /// </summary>
        /// <returns>UsersChoice of the action to perform</returns>
        public static UsersFunctionChoices GetUsersChoice()
        {
            UsersFunctionChoices userChoice = (UsersFunctionChoices)(Int32.Parse(Console.ReadLine()));
            return userChoice;
        }


        /// <summary>
        /// This methods Reads data from console, converts to Integer and returns the integer
        /// </summary>
        /// <returns>Integer value entered by user</returns>
        public static int GetIntergerInput(string displayString = "\nPlease enter an integer value ")
        {
            Console.WriteLine(displayString);
            return Int32.Parse(Console.ReadLine());
        }
    }
}
