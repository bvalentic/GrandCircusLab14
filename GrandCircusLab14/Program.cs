using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're countin' gators 'n clonin' sheep!");

            Alligator gator = new Alligator(0);
            CountTestApp.GatorCount(gator);

            Sheep babe = new Sheep("Babe", 0);
            CountTestApp.SheepCount(babe);

            Console.WriteLine("Thanks for all your help! I feel real sleepy all of a sudden. . .");
            Console.ReadKey();
        }
    }
}
