using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    public class DefaultPriorityStrategy : IPriorityStrategy
    {
        public int CalculateHoursUntilSLALimit(DateTime timeReceived)
        {
            return 2;
        }
    }
}
