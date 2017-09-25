using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class Times
    {
        public static void CheckInTime()
        {
            string inCheck = "Din incheckningstid är ";

            DateTime time = DateTime.Now;
            Console.Write(inCheck);
            Console.WriteLine(time.ToString("HH:mm"));
        }

        public static void CheckOutTime()
        {
            string inCheck = "Din incheckningstid är ";

            DateTime time = DateTime.Now;
            Console.Write(inCheck);
            Console.WriteLine(time.ToString("HH:mm"));
        }
    }
}
