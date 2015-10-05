using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleDecimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            float y = 4.5f;
            short z = 5;
            double w = 1.7E+3;
            // Result of the 2nd argument is a double:
            Console.WriteLine("The sum is {0}", x + y + z + w);
        }
    }
}
