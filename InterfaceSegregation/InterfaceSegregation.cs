using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class InterfaceSegregation
    {


        public interface IProductRepository
        {
            void AddProduct();
        }

        public interface ICategoryRepository
        {
            void AddCategory();
        }

        public class ProductRepository : IProductRepository
        {

            public void AddProduct()
            {
                Console.WriteLine("Ürün eklendi");
            }
        }

        public class CategoryRepository : ICategoryRepository
        {

            public void AddCategory()
            {
                Console.WriteLine("Kategori eklendi");
            }
        }
    }
}
