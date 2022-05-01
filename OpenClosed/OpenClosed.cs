using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class OpenClosed
    {
       
        public interface IEmployee
        {
            void CalculateSalary();
        }

        public class FullTimeEmployee : IEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(16000);
            }
        }

        public class PartTimeEmployee : IEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(8000);
            }
        }

        public class SupportEmployee : IEmployee
        {
            public void CalculateSalary()
            {
                Console.WriteLine(5000);
            }
        }


        // Yeni ekleneccek olan Employee'lerimize IEmployee interface'ini implemente ederek herhangi bir değişiklik
        // yapmak zorunda kalmıyoruz.

        public class SalaryCalculator
        {
            private readonly IEmployee _employee;

            public SalaryCalculator(IEmployee employee)
            {
                _employee = employee;
            }

            public void CalculateSalary()
            {
                _employee.CalculateSalary();
            }
        }


    }
}
