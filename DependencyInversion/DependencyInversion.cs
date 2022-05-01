using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class DependencyInversion
    {
        interface IProductRepository
        {
           void GetProducts();
        }
        // EntityFramework ile çalıştığımızı düşünelim.
        public class EfProductRepository: IProductRepository
        {
            public void GetProducts()
            {
                Console.WriteLine("Entity Framework GetProducts");
            }
        }

        // Daha sonra dapper ile çalışmak istediğimizi düşünelim.
        public class DpProductRepository: IProductRepository
        {
            public void GetProducts()
            {
                Console.WriteLine("Dapper GetProducts");
            }
        }

        public class Controllerx
        {
            private readonly IProductRepository _productRepository;

            // EfProductRepository ve DpProductRepository ' IProductRepository olduğu için 
            // parametre olarak dışarıdan hangisini gönderirsek onun ile çalışır. 
            // Burada gevşek bağlılık söz konusudur.  
            // Peki IProductRepository istendiğinde EF mi DP mi gönderilecek ?
            // IoC Container' da bağımlılıklarımızı yöneterek bu sorunu hallediyoruz.
            // IoC Container' da IProductRepository'ye karlşılık gelecek concrete'i belirtiyoruz.
            public Controllerx(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }


            // Burası tamamen EntityFramework'e bağlı durumda.
            // Tek Tek tüm new leri new DpProductRepository ile değiştirmemiz gerekiyor.
            public void Action1()
            {
                _productRepository.GetProducts();
            }

            public void Action2()
            {
                _productRepository.GetProducts();

            }
            public void Action3()
            {
                _productRepository.GetProducts();
            }
        }
    }
}
