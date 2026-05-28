using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prueba Método 1
            int pos = 6;
            Console.WriteLine($"Fibonacci en posición {pos}: {Fibonacci(pos)}"); // Devuelve 8

            // Prueba Método 2
            string palabra = "Recursividad";
            Console.WriteLine($"Texto invertido: {InvertirCadena(palabra)}");

            // Prueba Método 3 (El arreglo DEBE estar ordenado)
            int[] numeros = { 3, 8, 12, 15, 21, 42, 50, 89 };
            int objetivo = 42;
            int resultado = BusquedaBinaria(numeros, objetivo, 0, numeros.Length - 1);

            if (resultado != -1)
                Console.WriteLine($"El número {objetivo} se encuentra en el índice: {resultado}");
            else
                Console.WriteLine($"El número {objetivo} no existe en el arreglo.");

            Console.ReadKey();
        }
        public static int Fibonacci(int n)
        {
            // Casos base: si es 0 devuelve 0, si es 1 devuelve 1
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Caso recursivo: f(n) = f(n-1) + f(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static string InvertirCadena(string texto)
        {
            // Caso base: Si la cadena está vacía o tiene un solo carácter, ya está invertida
            if (string.IsNullOrEmpty(texto) || texto.Length <= 1)
            {
                return texto;
            }

            // Caso recursivo: Toma el último carácter y le concatena 
            // el resultado de invertir el resto de la cadena.
            return texto[texto.Length - 1] + InvertirCadena(texto.Substring(0, texto.Length - 1));
        }
        public static int BusquedaBinaria(int[] arreglo, int buscar, int izquierda, int derecha)
        {
            // Caso base 1: El espacio de búsqueda se agotó, el elemento no existe
            if (izquierda > derecha)
            {
                return -1;
            }

            // Calculamos el punto medio para dividir el problema
            int medio = izquierda + (derecha - izquierda) / 2;

            // Caso base 2: Encontramos el elemento en el medio
            if (arreglo[medio] == buscar)
            {
                return medio;
            }

            // Caso recursivo 1: El número buscado es menor, descartamos la mitad derecha
            if (arreglo[medio] > buscar)
            {
                return BusquedaBinaria(arreglo, buscar, izquierda, medio - 1);
            }

            // Caso recursivo 2: El número buscado es mayor, descartamos la mitad izquierda
            return BusquedaBinaria(arreglo, buscar, medio + 1, derecha);
        }

    }
}
