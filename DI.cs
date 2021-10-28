using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_IoC
{
    class Dl : IProduct
    {
        public string Insertdata()
        {
            string val = "Dependency injection injected";
            Console.WriteLine(val);
            return val;
        }
    }
}
