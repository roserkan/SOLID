using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public  class BadCode
    {
        // Kuşların uçacağını ve yürüyeceğini bildirdik.
        public interface IBird
        {
            bool Fly();
            bool Walk();
        }

        // Şahin uçtu ve yürüdü
        public class Hawk : IBird
        {
            public bool Fly()
            {
                Console.WriteLine("Şahin uçtu");
                return true;
            }
            public bool Walk()
            {
                Console.WriteLine("Şahin yürüdü");
                return true;
            }
        }


        // Penguen yürüdü fakat uçamıyor
        // LSP:
        // Alt seviye sınıflardan oluşan nesnelerin/sınıfların,
        // ana(üst) sınıfın nesneleri ile yer değiştirdikleri zaman,
        // aynı davranışı sergilemesi gerekmektedir. Türetilen sınıflar,
        // türeyen sınıfların tüm özelliklerini kullanabilmelidir.
     
        public class Penguin : IBird
        {
            public bool Fly()
            {
                return false;
            }
            public bool Walk()
            {
                Console.WriteLine("Şahin yürüdü");
                return true;
            }
        }
    }
}
