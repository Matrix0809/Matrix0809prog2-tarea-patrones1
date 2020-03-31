using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Console.ReadKey();

            Singleton.Instance.mensaje = " *Actualizado*, Hola Benjamin";

            Console.WriteLine(Singleton.Instance.mensaje);

            Console.ReadKey();

        }
    }
}
