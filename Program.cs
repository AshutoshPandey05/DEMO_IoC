using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using Unity;

namespace DEMO_IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing IOC using unity Container in a Console Application !");
            UnityContainer IU = new UnityContainer();





            IU.RegisterType<BL>();
            IU.RegisterType<Dl>();

            IU.RegisterType<IProduct, Dl>();
            BL objDl = IU.Resolve<BL>();
            objDl.Insert();
            Console.ReadLine();

        }
    }
}
