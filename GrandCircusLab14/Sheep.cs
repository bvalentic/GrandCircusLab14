using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    public class Sheep : ICloneable, ICountable
    {
        string Name { get; set; }
        int Count { get; set; }

        public Sheep(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public static void NameSheep(Sheep sheep, string name)
        {//used exclusively to change the name of the cloned sheep
            sheep.Name = name;
        }

        public object Clone()
        {//my other cloning methods I tried made the original and the clone the same reference
         //so the name and the count would be the same for both, even after prompting for the clone's name
         //I basically ended up making the method do exactly what Clone normally does after consulting MSDN

            return (Sheep)this.MemberwiseClone();
        }

        public void FormatCount()
        {
            Console.WriteLine($"{this.Count} {this.Name}");
        }

        public int GetCount()
        {
            return this.Count;
        }

        public string GetCountString()
        {
            return this.Count.ToString();
        }

        public void IncrementCount()
        {
            Count++;
        }

        public void ResetCount()
        {
            Count = 0;
        }
    }
}
