using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Builders
{
    public class HealthSurveyBuilder : ISurveyBuilder
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
                    QuestionText = "Is the building secure?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 6,
                    QuestionOrder = 2,
                    QuestionText = "Are there any rusty knives on the floor?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 1,
                    QuestionOrder = 3,
                    QuestionText = "How many people live in the building?"
                },
                new Question()
                {
                    NumberOfPossibleAnswers = 3,
                    QuestionOrder = 4,
                    QuestionText = "Is the water clean to drink?"
                }
            };
        }

        public void SetSignatureRequired()
        {
            survey.SignatureRequired = false;
        }

        public void SetSurveyDisplayPosition()
        {
            survey.DisplayPosition = DisplayPosition.AfterJobCompletion;
        }

        public Survey GetSurvey()
        {
            return survey;
        }
    }
}
