using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Builders
{
    public class ApplianceSurveyBuilder : ISurveyBuilder
    {
        Survey survey = new Survey();

        public void SetQuestions()
        {
            survey.Questions = new List<Question>()
            {
                new Question()
                {
                    NumberOfPossibleAnswers = 2,
                    QuestionOrder = 1,
                    QuestionText = "What type of Appliance?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 3,
                    QuestionOrder = 2,
                    QuestionText = "What type of Model?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 1,
                    QuestionOrder = 3,
                    QuestionText = "What type of fuel?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 4,
                    QuestionOrder = 4,
                    QuestionText = "Is their a flue fitted to the appliance?"
                }
            };
        }

        public void SetSignatureRequired()
        {
            survey.SignatureRequired = false;
        }

        public void SetSurveyDisplayPosition()
        {
            survey.DisplayPosition = DisplayPosition.AfterAddPartAddition;
        }

        public Survey GetSurvey()
        {
            return survey;
        }
    }
}
