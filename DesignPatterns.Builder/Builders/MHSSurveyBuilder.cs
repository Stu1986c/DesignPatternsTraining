using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Builders
{
    public class MHSSurveyBuilder :ISurveyBuilder
    {
        Survey survey = new Survey();

        public void SetQuestions()
        {
            survey.Questions = new List<Question>()
            {
                new Question()
                {
                    NumberOfPossibleAnswers = 3,
                    QuestionOrder = 1,
                    QuestionText = "Is Immersion Heater Present?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 2,
                    QuestionOrder = 2,
                    QuestionText = "Is Meter Capped?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 2,
                    QuestionOrder = 3,
                    QuestionText = "Meter Location"
                }
            };
        }

        public void SetSignatureRequired()
        {
            survey.SignatureRequired = true;
        }

        public void SetSurveyDisplayPosition()
        {
            survey.DisplayPosition = DisplayPosition.AfterAddDefect;
        }

        public Survey GetSurvey()
        {
            return survey;
        }
    }
}
