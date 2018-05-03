using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Creators
{
    public class SurveyCreator
    {
        private readonly ISurveyBuilder _surveyBuilder;

        public SurveyCreator(ISurveyBuilder surveyBuilder)
        {
            _surveyBuilder = surveyBuilder;
        }

        public void CreateSurvey()
        {
            _surveyBuilder.SetQuestions();
            _surveyBuilder.SetSignatureRequired();
            _surveyBuilder.SetSurveyDisplayPosition();
        }

        public Survey GetSurvey()
        {
            return _surveyBuilder.GetSurvey();
        }
    }
}
