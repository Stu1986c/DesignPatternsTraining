using System;
using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Creators;
using NUnit.Framework;

namespace DesignPatterns.Builder.Tests
{
    [TestFixture]
    public class SurveyBuilderTests
    {
        [Test]
        public void CreateMHSSurvey()
        {
            //Arrange
            var sut = new SurveyCreator(new MHSSurveyBuilder());

            //Act
            sut.CreateSurvey();
            var survey = sut.GetSurvey();

            //Assert
            Assert.AreEqual(DisplayPosition.AfterAddDefect, survey.DisplayPosition);
            Assert.AreEqual(3, survey.Questions.Count);
            Assert.IsTrue(survey.SignatureRequired);
        }

        [Test]
        public void CreateHealthSurvey()
        {
            //Arrange
            var sut = new SurveyCreator(new HealthSurveyBuilder());

            //Act
            sut.CreateSurvey();
            var survey = sut.GetSurvey();

            //Assert
            Assert.AreEqual(DisplayPosition.AfterJobCompletion, survey.DisplayPosition);
            Assert.AreEqual(4, survey.Questions.Count);
            Assert.IsFalse(survey.SignatureRequired);
        }

        [Test]
        public void CreateApplianceSurvey()
        {
            //Arrange
            var sut = new SurveyCreator(new ApplianceSurveyBuilder());

            //Act
            sut.CreateSurvey();
            var survey = sut.GetSurvey();

            //Assert
            Assert.AreEqual(DisplayPosition.AfterAddPartAddition, survey.DisplayPosition);
            Assert.AreEqual(4, survey.Questions.Count);
            Assert.IsFalse(survey.SignatureRequired);
        }
    }
}
