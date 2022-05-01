using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class LiskovSubstitution
    {
        interface IBird
        {
        }
        interface IFlyableBirds: IBird
        {
            bool Fly();
        }
        interface IWalkableBirds: IBird
        {
            bool Walk();
        }

        public class Hawk : IFlyableBirds, IWalkableBirds
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

        // Penguen bir kuş olmasına rağmen uçması gerekmiyor.
        public class Penguin : IWalkableBirds
        {
            public bool Walk()
            {
                Console.WriteLine("Şahin yürüdü");
                return true;
            }
        }
    }
}
