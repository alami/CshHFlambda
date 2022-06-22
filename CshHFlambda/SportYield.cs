using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFlambda
{
    enum SportYield { Football, Baseball, Basketball, Hockey, Boxing, Rugby, Fencing }
    class ManualSportSequenceYield : IEnumerable<SportYield>
    {
        public IEnumerator<SportYield> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(SportYield)).Length - 1;
            for (int i = 0; i <= maxEnumValue; i++)
            {
                yield return (SportYield)i;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
    public class SportYieldTest
    {
        static public void Test ()
        {
            var sports = new ManualSportSequenceYield();
            foreach (var sport in sports)
                Console.WriteLine(sport);
        }
    }
}
