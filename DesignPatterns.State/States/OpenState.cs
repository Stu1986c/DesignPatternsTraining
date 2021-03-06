﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Entities;

namespace DesignPatterns.State.States
{
    public class OpenState : IJobState
    {
        public void Change(Job job)
        {
            job.State = new CheckInState();
        }

        public string ReportState()
        {
            return "Currently in Open State";
        }
    }
}
