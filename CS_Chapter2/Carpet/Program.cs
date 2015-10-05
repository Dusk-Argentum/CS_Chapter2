using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal l = 15;
            decimal w = 15;
            decimal c = l * w;
            Console.WriteLine("The cost to lay down {0} square feet of carpet is ${1}.", l * w, c); 
        }
    }
}
