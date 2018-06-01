using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WithNullObject
{
    public class Person : PersonBase
    {
        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
