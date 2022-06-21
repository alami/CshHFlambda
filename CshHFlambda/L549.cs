using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFlambda
{
    public class L549
    {
        static Random random => new Random();
        static double GetRandomDouble(int max) => max * random.NextDouble();
        //{  return max * random.NextDouble(); }
        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
        //{  Console.WriteLine($"The value is {d:0.0000}"); }
        public static void Test() {
            var value = L549.GetRandomDouble(100);
            L549.PrintValue(value);
        }
    }
}
