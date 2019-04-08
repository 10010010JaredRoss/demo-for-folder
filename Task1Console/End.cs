using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    public class End
    {

        public static void EndDisplay(Person user)
        {
            List<string> listVar = new List<string>();
            listVar.Add(user.FirstName.Substring(0, 1) + user.LastName);

            Console.Write("Press enter to close or one to show users.");
            string finalinput = Console.ReadLine();

            if (finalinput == "one")
            {
                foreach (string item in listVar)
                {
                    Console.WriteLine(item);
                    Console.ReadKey();
                }
            }
            else
            {

            }
        }
    }
}
