using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WithNullObject
{
    public abstract class PersonBase
    {
        public abstract string FirstName { get; set; }

        public abstract string LastName { get; set; }

        public abstract string FullName();

        #region NULL
        static readonly NullPerson nullPerson = new NullPerson();

        public static NullPerson NULL
        {
            get { return nullPerson; }
        }

        public class NullPerson : PersonBase
        {
            public override string FirstName { get; set; }
            public override string LastName { get; set; }
            public override string FullName()
            {
                return string.Empty;
            }
        }
       
        #endregion
    }
}
