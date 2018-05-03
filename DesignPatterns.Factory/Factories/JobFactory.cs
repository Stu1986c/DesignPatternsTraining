using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public static class JobFactory
    {
        public static IJob Create(int jobTypeId)
        {
            switch (jobTypeId)
            {
                case 1:
                    return new ServiceJob();
                case 2:
                    return new InstallationJob();
                case 3:
                    return new BreakdownJob();
                default:
                    return null;
            }
        }
    }
}
