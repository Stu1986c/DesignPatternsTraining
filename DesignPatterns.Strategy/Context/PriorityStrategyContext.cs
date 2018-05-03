using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy.Context
{
    public class PriorityStrategyContext
    {
        private IPriorityStrategy _priorityStrategy;

        public PriorityStrategyContext(IPriorityStrategy priorityStrategy)
        {
            _priorityStrategy = priorityStrategy;
        }

        public int ExecuteSLAStrategy(DateTime timeReceived)
        {
            return _priorityStrategy.CalculateHoursUntilSLALimit(timeReceived);
        }
    }
}
