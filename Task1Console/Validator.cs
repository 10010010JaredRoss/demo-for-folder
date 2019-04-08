using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    public class PersonValidator
    {

        public static bool Validate(Person person)
        {
            
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Messages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Messages.DisplayValidationError("last name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Email))
            {
                Messages.DisplayValidationError("Email");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Password))
            {
                Messages.DisplayValidationError("Password");
                return false;
            }

            if (person.Password == person.Confirm)
            {

            }
            else
            {
                Messages.PasswordError();
                return false;
            }

            return true;
        }
    }
}
