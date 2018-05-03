using System;
using DesignPatterns.Strategy.Context;
using DesignPatterns.Strategy.Strategies;
using NUnit.Framework;

namespace DesignPatterns.Strategy.Tests
{
    [TestFixture]
    public class PriorityStrategyTests
    {
        [Test]
        public void HighPriority_After1700Hrs()
        {
            //Arrange
            var sut = new PriorityStrategyContext(new HighPriorityStrategy());
            var dateTimeAfter1700Hrs = new DateTime(2018, 04, 20, 19, 25, 22);

            //Act
            var hoursUntilSLAFail = sut.ExecuteSLAStrategy(dateTimeAfter1700Hrs);

            //Assert
            Assert.AreEqual(5, hoursUntilSLAFail);
        }

        [Test]
        public void HighPriority_Before1700Hrs()
        {
            //Arrange
            var sut = new PriorityStrategyContext(new HighPriorityStrategy());
            var dateTimeAfter1700Hrs = new DateTime(2018, 07, 20, 9, 30, 29);

            //Act
            var hoursUntilSLAFail = sut.ExecuteSLAStrategy(dateTimeAfter1700Hrs);

            //Assert
            Assert.AreEqual(1, hoursUntilSLAFail);
        }

        [Test]
        public void MediumPriority()
        {
            //Arrange
            var sut = new PriorityStrategyContext(new MediumPriorityStrategy());
            var dateTime = new DateTime(2018, 07, 20, 9, 30, 29);

            //Act
            var hoursUntilSLAFail = sut.ExecuteSLAStrategy(dateTime);

            //Assert
            Assert.AreEqual(12, hoursUntilSLAFail);
        }

        [Test]
        public void LowPriority_InJanuary()
        {
            //Arrange
            var sut = new PriorityStrategyContext(new LowPriorityStrategy());
            var dateTimeInJanuary = new DateTime(2018, 01, 20, 9, 30, 29);

            //Act
            var hoursUntilSLAFail = sut.ExecuteSLAStrategy(dateTimeInJanuary);

            //Assert
            Assert.AreEqual(48, hoursUntilSLAFail);
        }

        [Test]
        public void LowPriority_NotInJanuary()
        {
            //Arrange
            var sut = new PriorityStrategyContext(new LowPriorityStrategy());
            var dateTimeNotInJanuary = new DateTime(2018, 11, 23, 19, 30, 29);

            //Act
            var hoursUntilSLAFail = sut.ExecuteSLAStrategy(dateTimeNotInJanuary);

            //Assert
            Assert.AreEqual(24, hoursUntilSLAFail);
        }
    }
}
