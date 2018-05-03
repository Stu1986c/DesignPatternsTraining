using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder
{
    public class Survey
    {
        public List<Question> Questions { get; set; }

        public bool SignatureRequired { get; set; }

        public DisplayPosition DisplayPosition { get; set; }
    }

    public enum DisplayPosition
    {
        AfterCheckIn,
        AfterJobCompletion,
        AfterAddDefect,
        AfterAddPartAddition
    }
}
