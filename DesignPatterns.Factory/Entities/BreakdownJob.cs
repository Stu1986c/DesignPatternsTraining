using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class BreakdownJob : IJob
    {
        public string ReturnType()
        {
            return "Breakdown";
        }

        public bool ChangeRootCause()
        {
            return true;
        }
    }
}
