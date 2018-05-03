using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface ISurveyBuilder
    {
        void SetQuestions();
        void SetSignatureRequired();
        void SetSurveyDisplayPosition();

        Survey GetSurvey();
    }
}
