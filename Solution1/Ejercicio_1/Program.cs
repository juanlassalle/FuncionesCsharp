using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        //Se requiere un algoritmo para obtener la suma de diez cantidades mediante
        //la utilización de un ciclo "Mientras". Usar Métodos para resolver el ejercicio.
        static void Main(string[] args)
        {
            SumarDiezCantidades();
        }

        private static void SumarDiezCantidades()
        {
            int suma = 0;
            int contador = 1;
            int valor;

            while (contador <= 10)
            {
                Console.Write("Ingrese el valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                suma = suma + valor;
                contador++;
            }
            Console.WriteLine($"La suma de los valores es {suma}");
        }
    }
}
