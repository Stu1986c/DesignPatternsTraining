using DesignPatterns.WithoutNullObject.Repositories;
using NUnit.Framework;

namespace DesignPatterns.NullObject.UnitTests
{
    [TestFixture]
    public class PersonRepositoryTests
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
