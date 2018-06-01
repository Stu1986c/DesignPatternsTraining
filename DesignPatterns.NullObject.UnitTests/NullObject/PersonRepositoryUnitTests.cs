using DesignPatterns.WithNullObject;
using DesignPatterns.WithNullObject.Repositories;
using NUnit.Framework;

namespace DesignPatterns.NullObject.UnitTests.NullObject
{
    [TestFixture]
    public class PersonRepositoryUnitTests
    {
        [Test]
        public void PersonRepository_GetPersonByFirstName()
        {
            //Arrange
            var firstName = "Bob";
            var lastName = "Smith";
            var fullname = string.Empty;

            //Act
            var person = PersonRepository.GetPersonByFirstName(firstName);
            fullname = person.FullName();

            //Assert
            //TODO

        }
    }
}
