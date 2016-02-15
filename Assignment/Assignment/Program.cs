using System;
using UserFunctions;
using UserChoices;


namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var runApplicationFlag = true;

            do
            {
                runApplicationFlag = PromptForUserOptions();

            } while (runApplicationFlag);

        }

        /// <summary>
        /// This method prompts for User-Choices and returns a false if user decides to end application
        /// </summary>
        /// <returns></returns>
        private static bool PromptForUserOptions()
        {
            var runApplicationFlag = true;

            try
            {
                UsersFunctionChoices userChoice = UserInteractionFunctions.GetUserActionChoice();
                UserInteractionFunctions.ProcessUsersChoice(userChoice);

                if (userChoice == UsersFunctionChoices.EndApplication)
                    runApplicationFlag = false;

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Bad Input !!!" + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message + ex.GetType());
            }

            return runApplicationFlag;
        }
    }
}
