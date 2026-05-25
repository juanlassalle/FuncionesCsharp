using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        //Realice un algoritmo usando un método para generar e imprimir los números pares que se
        //encuentran entre 0 y 20; y luego los impares el mismo condicional en otro método.
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
