using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy.Context;
using DesignPatterns.Strategy.Entities;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What priority is this Job? High, Medium or Low?");

            var priority = Console.ReadLine();

            PriorityStrategyContext strategy = new PriorityStrategyContext(new DefaultPriorityStrategy());

            if (Enum.TryParse(priority, out PriorityEnum priorityEnum))
            {
                switch (priorityEnum)
                {
                    case PriorityEnum.High: 
                        strategy = new PriorityStrategyContext(new HighPriorityStrategy());
                        break;
                    case PriorityEnum.Medium:
                        strategy = new PriorityStrategyContext(new MediumPriorityStrategy());
                        break;
                    case PriorityEnum.Low:
                        strategy = new PriorityStrategyContext(new LowPriorityStrategy());
                        break;
                    default:
                        strategy = new PriorityStrategyContext(new HighPriorityStrategy());
                        break;
                }
            }

            var theTimeRightNow = DateTime.UtcNow;

            var timeUntilSLARequired = strategy.ExecuteSLAStrategy(theTimeRightNow);

            Console.WriteLine($"This Job needs to be completed in {timeUntilSLARequired} hours");
            Console.ReadLine();
        }
    }
}
