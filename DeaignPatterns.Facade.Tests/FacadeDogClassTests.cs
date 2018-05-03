using System;
using DesignPatterns.Facade.Entity;
using NUnit;
using NUnit.Framework;

namespace DeaignPatterns.Facade.Tests
{
    [TestFixture]
    public class FacadeDogClassTests
    {
        [Test]
        [TestCase(5, 9, 12)]
        [TestCase(15, 10, 13)]
        [TestCase(0, 4, 6)]
        [TestCase(10, 14, 19)]
        [TestCase(101, 96, 144)]
        public void DoItAll_Covering(int numberProvided, int expectedNumberOfDogs, int expectedTotalNumberOfLegs)
        {
            var sut = new FacadeDogClass();

            var outcome = sut.DoItAll(numberProvided);

            Assert.AreEqual(expectedNumberOfDogs, outcome.Item1);
            Assert.AreEqual(expectedTotalNumberOfLegs, outcome.Item2);
        }
    }
}
