using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class CountUtil
    {
        public static void Count(ICountable c, int maxCount)
        {//counts up to the specified max and prints each count
            while (c.GetCount() < maxCount)
            {
                c.IncrementCount();
                c.FormatCount();
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
