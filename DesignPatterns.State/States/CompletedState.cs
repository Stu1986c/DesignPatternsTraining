using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Entities;

namespace DesignPatterns.State.States
{
    public class CompletedState : IJobState
    {
        public void Change(Job job)
        {
            throw new Exception("You can't change state when the Job is Completed");
        }

        public string ReportState()
        {
            return "Currently in Completed State";
        }
    }
}
