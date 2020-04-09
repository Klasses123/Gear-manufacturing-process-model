using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear
{
    public class Gear
    {
        public int ProcessingStartTime { get; }
        public int ProcessingEndTime { get; set; }
        public Gear(int processingStartTime, int processingTime)
        {
            this.ProcessingStartTime = processingStartTime;
            this.ProcessingEndTime = processingTime + processingStartTime;
        }
    }
}
