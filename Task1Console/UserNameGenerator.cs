using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{

    public class UserNameGenerator
    {
        public static void CreateAccount(Person user)
        {
            List<string> listVar = new List<string>();
            listVar.Add(user.FirstName.Substring(0, 1) + user.LastName);
        }
    }
}
