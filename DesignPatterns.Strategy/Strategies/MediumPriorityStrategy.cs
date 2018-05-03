using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    public class MediumPriorityStrategy : IPriorityStrategy
    {
        public int CalculateHoursUntilSLALimit(DateTime timeReceived)
        {
            int hoursUntilSLA = 12;

            return hoursUntilSLA;
        }
    }
}
