using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear
{
    public static class Randomizer
    {
        public static int NextGearTime(Random rnd)
        {
            return rnd.Next(5, 15);
        }

        public static int CementationTime(Random rnd)
        {
            return rnd.Next(3, 17);
        }

        public static int HardeningTime(Random rnd)
        {
            return rnd.Next(4, 16);
        }
    }
}
