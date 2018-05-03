using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class InstallationJob : IJob
    {
        public string ReturnType()
        {
            return "Installation";
        }

        public bool ChangeRootCause()
        {
            return false;
        }
    }
}
