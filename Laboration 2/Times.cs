using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class Times
    {
        public static void CheckTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("HH:mm"));
        }
    }
}
