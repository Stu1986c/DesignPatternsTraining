using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Entities;

namespace DesignPatterns.State
{
    public interface IJobState
    {
        void Change(Job job);

        string ReportState();
    }
}
