using System;
using DesignPatterns.State.Entities;
using NUnit.Framework;

namespace DesignPatterns.State.Tests
{
    [TestFixture]
    public class JobTests
    {
        [Test]
        public void CreateNewJob_InOpenState()
        {
            //Arrange
            var sut = new Job();

            //Act
            
            //Assert
            Assert.AreEqual("Currently in Open State", sut.State.ReportState());
        }

        [Test]
        public void CheckIntoJob_InCheckInState()
        {
            //Arrange
            var sut = new Job();

            //Act
            sut.ChangeState();

            //Assert
            Assert.AreEqual("Currently in Check-In State", sut.State.ReportState());
        }

        [Test]
        public void CheckOutOfJob_InCheckOutState()
        {
            //Arrange
            var sut = new Job();

            //Act
            sut.ChangeState();
            sut.CheckinInError = true;
            sut.ChangeState();

            //Assert
            Assert.AreEqual("Currently in Check-Out State", sut.State.ReportState());
        }

        [Test]
        public void CheckInAndStartWork_InProgressState()
        {
            //Arrange
            var sut = new Job();

            //Act
            sut.ChangeState();
            sut.CheckinInError = true;
            sut.ChangeState();
            sut.ChangeState();
            sut.ChangeState();

            //Assert
            Assert.AreEqual("Currently in In Progress State", sut.State.ReportState());
        }

        [Test]
        public void CompleteJob_InCompleteState()
        {
            //Arrange
            var sut = new Job();

            //Act
            sut.ChangeState();
            sut.CheckinInError = true;
            sut.ChangeState();
            sut.ChangeState();
            sut.ChangeState();
            sut.ChangeState();

            //Assert
            Assert.AreEqual("Currently in Completed State", sut.State.ReportState());
        }

        [Test]
        public void CompleteJob_CannotChangeState()
        {
            //Arrange
            var sut = new Job();

            //Act
            sut.ChangeState();
            sut.CheckinInError = true;
            sut.ChangeState();
            sut.ChangeState();
            sut.ChangeState();
            sut.ChangeState();
            var ex = Assert.Throws<Exception>(() => sut.ChangeState());


            //Assert
            Assert.That(ex.Message, Is.EqualTo("You can't change state when the Job is Completed"));
        }
    }
}
