using System;
using DesignPatterns.Factory.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace DesignPatterns.Factory.Tests
{
    [TestFixture]
    public class JobFactoryTests
    {
        [Test]
        public void CreateNewServiceJob()
        {
            //Arrange
            var id = 1;

            //Act
            var sut = JobFactory.Create(id);

            //Assert
            Assert.AreEqual("Service", sut.ReturnType());
            Assert.IsFalse(sut.ChangeRootCause());
        }

        [Test]
        public void CreateNewInstallationJob()
        {
            //Arrange
            var id = 2;

            //Act
            var sut = JobFactory.Create(id);

            //Assert
            Assert.AreEqual("Installation", sut.ReturnType());
            Assert.IsFalse(sut.ChangeRootCause());
        }

        [Test]
        public void CreateNewBreakdownJob()
        {
            //Arrange
            var id = 3;

            //Act
            var sut = JobFactory.Create(id);

            //Assert
            Assert.AreEqual("Breakdown", sut.ReturnType());
            Assert.IsTrue(sut.ChangeRootCause());
        }
    }
}
