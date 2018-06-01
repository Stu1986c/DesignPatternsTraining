using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WithoutNullObject
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
