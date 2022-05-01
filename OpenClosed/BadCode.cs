using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class BadCode
    {
        public class FullTimeEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(16000);
            }
        }

        public class PartTimeEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(8000);
            }
        }



        // Open Close Prensibi : 
        // Sınıflarımız/fonksiyonlarımız değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalıdır.
        // Yukarıdaki iki Employee haricinde SupportEmployee'nin sonra eklendiğini düşünelim.
        // CalculateSalary methodumuza else if eklememiz gerekir. 
        public class SupportEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(5000);
            }
        }

        public void CalculateSalary(string employeeType)
        {
            if (employeeType == "Full")
            {
                new FullTimeEmployee().CalculateSalary();
            }
            else if (employeeType == "Support")
            {
                new FullTimeEmployee().CalculateSalary(); // Sonradan eklendi.
            }
            else
            {
                new PartTimeEmployee().CalculateSalary();

            }
        }

    }
}
}
