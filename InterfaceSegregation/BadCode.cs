using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class BadCode
    {
        // Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş
        // birden fazla arayüz oluşturmayı tercih etmemizi söyleyen prensiptir.
        // Burada Ürün ve Kategori ile işlemler tek yerde ele alınmış.
        public interface IRepository
        {
            void AddProduct();
            void AddCategory();
        }

        public class ProductRepository : IRepository
        {

            public void AddProduct()
            {
                Console.WriteLine("Ürün eklendi");
            }
            public void AddCategory()
            {
                // Burada kategori eklenmez
            }
        }

        public class CategoryRepository : IRepository
        {

            public void AddProduct()
            {
                // Burada ürün eklenmez
            }
            public void AddCategory()
            {
                Console.WriteLine("Kategori eklendi");
            }
        }
    }
}
