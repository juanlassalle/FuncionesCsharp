using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focos lote = new Focos();
            lote.Ejecutar();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
