using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.States;

namespace DesignPatterns.State.Entities
{
    public class Job
    {
        public IJobState State { get; set; }
        public bool CheckinInError { get; set; }

        public Job()
        {
            State = new OpenState();
        }

        public void ChangeState()
        {
            State.Change(this);
        }

        public void ReportState()
        {
            State.ReportState();
        }
    }
}
