using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Entities;

namespace DesignPatterns.State.States
{
    public class CheckInState : IJobState
    {
        public void Change(Job job)
        {
            if (job.CheckinInError)
            {
                job.State = new CheckOutState();
                job.CheckinInError = false;
            }
            else
            {
                job.State = new InProgressState();
            }
            
        }

        public string ReportState()
        {
            return "Currently in Check-In State";
        }
    }
}
