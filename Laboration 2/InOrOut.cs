using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class InOrOut
    {
        public static void CheckIn()
        {
            string theChoice;
            Console.WriteLine("press [i] to check in.");
            theChoice = Console.ReadLine();

            if (theChoice == "i")
                CheckingIn();
            else
                CheckIn();
        }

        public static void CheckOut()
        {
            string theChoice;
            Console.WriteLine("press [o] to check out.");
            theChoice = Console.ReadLine();

            if (theChoice == "o")
                CheckingOut();
            else
                CheckOut();
        }

        private static void CheckingIn()
        {
            Times.CheckInTime();
        }

        private static void CheckingOut()
        {
            Times.CheckOutTime();
        }
    }
}
