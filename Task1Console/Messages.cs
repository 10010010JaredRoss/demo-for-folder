using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.Write("Press enter to close or 1 to show users.");
            string finalinput = Console.ReadLine();

        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }

        public static void PasswordError()
        {
            Console.WriteLine("The password you have enterd did not match");
        }
    }
}
