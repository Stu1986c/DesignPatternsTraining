using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Entities
{
    public class Question
    {
        public string QuestionText { get; set; }

        public int NumberOfPossibleAnswers { get; set; }

        public int QuestionOrder { get; set; }
    }
}
