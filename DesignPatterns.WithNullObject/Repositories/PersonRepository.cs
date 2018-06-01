using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WithNullObject.Repositories
{
    public class PersonRepository
    {

        static IList<PersonBase> personRepo = GetAllPeople();

        private static IList<PersonBase> GetAllPeople()
        {
            return new List<PersonBase>();
        }

        public static PersonBase GetPersonByFirstName(string firstName)
        {
            return personRepo.FirstOrDefault(x => x.FirstName == firstName) ?? PersonBase.NULL;
        }
    }
}
