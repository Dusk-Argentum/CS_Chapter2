using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many eggs for the first chicken?: ");
            int eggs1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs for the second chicken?: ");
            int eggs2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs for the third chicken?: ");
            int eggs3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs for the fourth chicken?: ");
            int eggs4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total amount of eggs is {0}, making {1} total dozens.", eggs1 + eggs2 + eggs3 + eggs4, ((eggs1 + eggs2 + eggs3 + eggs4) / 12));
        }
    }
}
