using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    //Se requiere un algoritmo para obtener la suma de diez cantidades mediante
    //la utilización de un ciclo FOR. Usando dos métodos para resolver el ejercicio.
    //El primer método se encargará de solicitar los datos y el segundo método se
    //encargará de realizar la suma y el tercero de imprimir la suma.
    internal class Program
    {
        static void Main(string[] args)
        {
            ImprimirSuma();
        }

        private static void ImprimirSuma()
        {
            Console.WriteLine($"La suma de los valores es {SolicitarDatos()}");
        }

        private static int SolicitarDatos()
        {
            int suma = 0;
            int valor;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Ingresar valor {i}: ");
                valor = Convert.ToInt32(Console.ReadLine());

                suma = SumarValores(suma, valor);
            }

            return suma;
        }
        private static int SumarValores(int _suma, int _valor)
        {
            return _suma + _valor;
        }
    }
}
