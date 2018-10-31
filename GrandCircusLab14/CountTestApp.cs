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
        {//takes an input sheep, counts to 2, 
         //clones it, counts the clone to 3, 
         //then resets the original sheep and counts once
            Console.WriteLine("Counting sheep. . .");
            CountUtil.Count(sheep, Counter());
            Console.WriteLine("Cloning sheep. . .");
            Sheep dolly = (Sheep)sheep.Clone();
            Sheep.NameSheep(dolly,GetName());
            dolly.ResetCount();
            CountUtil.Count(dolly, Counter());
            Console.WriteLine("Counting sheep. . .");
            sheep.ResetCount();
            CountUtil.Count(sheep, Counter());
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
