using System;
using UserChoices;
using UserInputFunctions;
using UserInterfaceFunctions;

namespace UserFunctions
{
    /// <summary>
    /// This class provides methods for the interaction with the user
    /// </summary>
    public class UserInteractionFunctions
    {
        /// <summary>
        /// This method takes Users input choice of Action and validates the same
        /// </summary>
        /// <returns>Returns the Users Choice of Action </returns>
        public static UsersFunctionChoices GetUserActionChoice()
        {
            var usersFunctionChoice = PromptUsersChoice();
            var isValidUserFunctionChoice = ValidateUsersChoice(usersFunctionChoice);

            if (!isValidUserFunctionChoice)
            {
                throw new InvalidOperationException("\nBad Option Choice!! Please Try Again with a Valid Choice\n");
            }

            return usersFunctionChoice;
        }

        /// <summary>
        /// This method prompts the user options and takes a UserFunctionChoice input from user
        /// </summary>
        /// <returns>Returns the Users Choice of Action </returns>
        private static UsersFunctionChoices PromptUsersChoice()
        {
            Console.Write("\nPlease enter the action to perform " +
                "\n1) Print Triangular Output using String" +
                "\n2) Print Triangular Output using Start, End Characters" +
                "\n3) Count Distinct String Characters(Case Sensitive)" +
                "\n4) Count Distinct String Characters(Case InSensitive)" +
                "\n5) Print *** Triagle" +
                "\n6) End Application\n\nPlease enter your choice : ");

            var userChoice = UserInputGathering.GetUsersChoice();
            return userChoice;
        }

        /// <summary>
        /// This method performs validation to check that the userchoice is valid
        /// </summary>
        /// <param name="userChoice"> Users Choice inputted for action</param>
        /// <returns>Flag indicating the users choice is valid or not</returns>
        private static bool ValidateUsersChoice(UsersFunctionChoices userChoice)
        {
            var isValidUserChoiceFlag = UserInputValidation.IsValidUserChoice(userChoice);
            return isValidUserChoiceFlag;
        }


        /// <summary>
        /// This method calls the appropriate methods based on the UsersChoice of activity
        /// </summary>
        /// <param name="userChoice">This is the UsersChoice which has been inputted by User.</param>
        public static void ProcessUsersChoice(UsersFunctionChoices userChoice)
        {
        
            switch (userChoice)
            {
                case UsersFunctionChoices.PrintTriangularOutputUsingString:
                    UserInterfaceAccessFunctions.PrintTriangleUsingString();
                    break;
                case UsersFunctionChoices.PrintTriangularOutputUsingStartEndCharacters:
                    UserInterfaceAccessFunctions.PrintTriangleUsingStartEndCharacters();
                    break;
                case UsersFunctionChoices.CountDistinctCharactersCaseSensitive:
                    UserInterfaceAccessFunctions.CountCharactersCaseSensitive();
                    break;
                case UsersFunctionChoices.CountDistinctCharactersCaseInsensitive:
                    UserInterfaceAccessFunctions.CountCharactersCaseInSensitive();
                    break;
                case UsersFunctionChoices.PrintStarTriangle:
                    UserInterfaceAccessFunctions.PrintStarTriangle();
                    break;
                case UsersFunctionChoices.EndApplication:
                    Console.WriteLine("\nEnding Application! Thanks for Using our Application!!\n");
                    return;

            }
        }

    }
}
