using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                Messages.EndApplication();
                return;
            }

            UserNameGenerator.CreateAccount(user);

            End.EndDisplay(user);
        }
    }
}
