using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 5; 
            int endNumber = 103;
            int argument = 7;

            for (int i = startNumber; i <= endNumber; i += argument)
            {
                Console.WriteLine(i);

            }
        }
    }
}
