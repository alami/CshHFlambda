using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFlambda
{
    public class YieldReturn
    {
        static IEnumerable<string> SimpleEnumerable()
        {
            yield return "apples";
            yield return "oranges";
            yield return "bananas";
            yield return "unicorns";
        }
        static public void Test ()
        {
            foreach (var s in SimpleEnumerable()) Console.WriteLine(s);
        }
    }
}
