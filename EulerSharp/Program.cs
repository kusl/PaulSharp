using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int threes_and_fives = ThreesAndFives.find_sum(13);
            Console.WriteLine(threes_and_fives);
            Console.Read();
        }
    }
}
