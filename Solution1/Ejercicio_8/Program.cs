using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
       //Realice un algoritmo que, a través de un método principal de impresión, coordine la llamada a dos
       //métodos independientes. El primero debe recorrer los números del 0 al 20 e imprimir únicamente los
       //valores pares utilizando el operador de residuo. El segundo método debe realizar el mismo
       //recorrido (de 0 a 20) pero, utilizando una estructura de salto (continue) cuando detecte un número
       //par, debe omitir su impresión para lograr mostrar únicamente los números impares.
        static void Main(string[] args)
        {
            ImprimirNumeros();
        }
        private static void ImprimirNumeros()
        {
            ImprimirNumerosPares();
            ImprimirNumerosImpares();
        }
        private static void ImprimirNumerosPares()
        {
            Console.WriteLine("========== Números Pares entre 0 y 20 ==========");

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Números pares {i}");
                }
            }
        }
        private static void ImprimirNumerosImpares()
        {
            Console.WriteLine("========== Números Impares entre 0 y 20 ==========");

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue;    
                }

                Console.WriteLine($"Números Impares {i}");
            }
        }

    }
}
