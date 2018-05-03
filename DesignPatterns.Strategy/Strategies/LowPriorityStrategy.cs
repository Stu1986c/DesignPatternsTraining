using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    public class LowPriorityStrategy : IPriorityStrategy
    {
        public int CalculateHoursUntilSLALimit(DateTime timeReceived)
        {
            var isJanaury = timeReceived.Month == 1;

            var hoursUntilSLA = isJanaury ? 48 : 24;

            return hoursUntilSLA;
        }
    }
}
