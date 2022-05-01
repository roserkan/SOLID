using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SingleResponsibility
    {
        // User class'ından kendi dışındaki sorumlulukları çıkardık.
        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        public class UserManager
        {
            public void Add()
            {
                // Business codes
            }
        }


        public class UserValidator
        {
            public void UserValidation()
            {
                // Validation codes
            }
        }
    }
}
