using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class InOrOut
    {
        public static void MakeAChoice()
        {
            Console.WriteLine("press [s] to check in / [e] to check out.");
            string theChoice = Console.ReadLine();
            if (theChoice == "s")
                CheckingIn();
            else if (theChoice == "e")
                CheckingOut();
            else
                MakeAChoice();
        }

        private static void CheckingOut()
        {
            Times.CheckTime();
        }
        private static void CheckingIn()
        {
            Times.CheckTime();
        }
    }
}
