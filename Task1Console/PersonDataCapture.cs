using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for user information
            Person output = new Person();

            Console.Write("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            output.LastName = Console.ReadLine();

            Console.Write("What is your Email: ");
            output.Email = Console.ReadLine();

            Console.Write("What is your Password: ");
            output.Password = Console.ReadLine();

            Console.Write("Confirm Password: ");
            output.Confirm = Console.ReadLine();

            return output;
        }
    }
}
