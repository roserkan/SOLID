using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class BadCode
    {

        // Bir sınıf ne kadar fazla sorumluluk alırsa, o kadar fazla değişime uğramak zorunda kalır.
        // Burada User sınıfına sorumluluğu dışında validasyon ve iş sorumlulukları eklenmiş.

        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void UserValidation()
            {
                // Validation codes
            }


            public void Add()
            {
                // Business codes
            }
        }
    
    }




}
