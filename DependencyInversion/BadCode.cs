using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    // Sınıflar arası bağımlılıklar olabildiğince az olmalıdır
    // özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
    public class BadCode
    {
        // EntityFramework ile çalıştığımızı düşünelim.
        public class EfProductRepository
        {
            public void GetProducts()
            {
                Console.WriteLine("Entity Framework GetProducts");
            }
        }

        // Daha sonra dapper ile çalışmak istediğimizi düşünelim.
        public class DpProductRepository
        {
            public void GetProducts()
            {
                Console.WriteLine("Dapper GetProducts");
            }
        }

        public class Controllerx
       {
            // Burası tamamen EntityFramework'e bağlı durumda.
            // Tek Tek tüm new leri new DpProductRepository ile değiştirmemiz gerekiyor.
            public void Action1()
            {
                EfProductRepository productRepository = new EfProductRepository();
                //EfProductRepository productRepository = new DpProductRepository();

                productRepository.GetProducts();
            }

            public void Action2()
            {
                EfProductRepository productRepository = new EfProductRepository();
                //EfProductRepository productRepository = new DpProductRepository();

                productRepository.GetProducts();
            }
            public void Action3()
            {
                EfProductRepository productRepository = new EfProductRepository();
                //EfProductRepository productRepository = new DpProductRepository();

                productRepository.GetProducts();
            }
        }
    }
}
