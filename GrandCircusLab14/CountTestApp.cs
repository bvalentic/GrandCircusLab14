using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class CountTestApp
    {
        public static void GatorCount(Alligator gator)
        {//takes an input alligator and counts to 3
            Console.WriteLine("Counting alligators. . .");
            CountUtil.Count(gator, Counter());
        }

        public static void SheepCount(Sheep sheep)
        {//takes an input sheep, counts to an input, 
         //clones it, counts the clone to another input, 
         //then resets the original sheep and counts to a final input
            Console.WriteLine("Counting sheep. . .");
            CountUtil.Count(sheep, Counter());

            Console.WriteLine("Cloning sheep. . .");
            Sheep dolly = Cloner(sheep);
            CountUtil.Count(dolly, Counter());

            Console.WriteLine("Counting sheep. . .");
            sheep.ResetCount();
            CountUtil.Count(sheep, Counter());
        }

        public static Sheep Cloner(Sheep sheep)
        {//clones a sheep from an input sheep, renames it, and resets the count to 0
            Sheep dolly = (Sheep)sheep.Clone();
            Sheep.NameSheep(dolly, GetName());
            dolly.ResetCount();
            return dolly;
        }

        public static int Counter()
        {//prompts user for the number of objects counted
            return Validator.CheckNum("How many should be counted? ", "Please enter a positive whole number: ", 1);
        }

        public static string GetName()
        {//prompts user to name the cloned sheep
            Console.Write("What should the cloned sheep's name be? ");
            return Console.ReadLine();
        }
    }
}
