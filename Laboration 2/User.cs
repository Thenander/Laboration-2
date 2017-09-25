using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class User
    {
        public static void Person()
        {

            string forName, lastName, fullName;

            Console.Write("Skriv in ditt förnamn: ");
            forName = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn: ");
            lastName = Console.ReadLine();

            fullName = forName + " " + lastName;

            Console.WriteLine(fullName);
        }
    }
}
