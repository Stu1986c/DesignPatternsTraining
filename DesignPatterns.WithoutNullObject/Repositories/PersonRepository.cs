using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WithoutNullObject.Repositories
{
    public class PersonRepository
    {

        static IList<Person> personRepo = GetAllPeople();

        private static IList<Person> GetAllPeople()
        {
            return new List<Person>();
        }

        public static Person GetPersonByFirstName(string firstName)
        {
            return personRepo.FirstOrDefault(x => x.FirstName == firstName);
        }
    }
}
