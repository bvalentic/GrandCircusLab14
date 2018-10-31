using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class Validator
    {
        public static int CheckNum(string promptString, string errorString, int minNum)
        {//checks to make sure the user input is an integer greater than a certain number
            Console.Write(promptString);
            int inputNum;
            string inputString = Console.ReadLine();
            while (!(int.TryParse(inputString, out inputNum)) || int.Parse(inputString) < minNum)
            {
                Console.WriteLine($"I'm sorry, I don't understand. {errorString}");
                inputString = Console.ReadLine();
            }
            return inputNum;
        }
    }
}
