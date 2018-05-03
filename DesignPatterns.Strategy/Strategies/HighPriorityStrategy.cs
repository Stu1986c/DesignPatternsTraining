using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    public class HighPriorityStrategy : IPriorityStrategy
    {
        public int CalculateHoursUntilSLALimit(DateTime timeReceived)
        {
            var afterFivePM = timeReceived.Hour > 16;

            var hoursUntilSLA = afterFivePM ? 5 : 1;

            return hoursUntilSLA;
        }
    }
}
