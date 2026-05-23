using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        //Se requiere un algoritmo para obtener la suma de diez cantidades mediante
        //la utilización de un ciclo Repite. Usando dos métodos para resolver el ejercicio.
        //El primer método se encargará de solicitar los datos y el segundo método se
        //encargará de realizar la suma.

        private static int suma = 0;
        static void Main(string[] args)
        {
            SolicitarDatos();
            Console.WriteLine($"Los valores sumados son: {suma}");
        }
        private static void SolicitarDatos()
        {
            int valor;
            int contador = 1;

            do
            {
                Console.Write("Ingresar valor: ");
                valor = Convert.ToInt32(Console.ReadLine());

                SumarValores(valor);
                contador++;
            }
            while (contador <= 10);
        }

        private static void SumarValores(int _valor)
        {
            suma = suma + _valor;
            
        }

    }
}
