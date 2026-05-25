using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        //Realice un algoritmo para generar N elementos de la sucesión de Fibonacci
        //(0, 1, 1, 2, 3, 5, 8, 13,?). Resolver el ejercicio utilizando métodos como crea conveniente
        static void Main(string[] args)
        {
            ImprimirSucesionFibonacci();
        }
        private static bool ValidarNElementos(string _entrada, out int _nElementos)
        {
            bool esValido = int.TryParse(_entrada, out _nElementos) && _nElementos > 0;

            if (!esValido)
            {
                Console.WriteLine("Error. El valor ingresado no es correcto");
            }

            return esValido;
        }
        private static int IngresarNElementos()
        {
            int nElementos;
            string entrada;
            bool esValido;

            do
            {
                Console.Write("Ingresar N cantidades: ");
                entrada = Console.ReadLine();
                esValido = ValidarNElementos(entrada, out nElementos);
            }
            while (!esValido);

            return nElementos;
        }
        private static void ImprimirSucesionFibonacci()
        {

            int nElementos = IngresarNElementos();

            int valorInicial = 0;
            int valorSiguiente = 1;

            if (nElementos >= 1)
            {
                Console.WriteLine(valorInicial);
            }
            if (nElementos >= 2)
            {
                Console.WriteLine(valorSiguiente);
            }

            for (int i = 3; i <= nElementos; i++)
            {
                int valorGenerado = valorInicial + valorSiguiente;

                Console.WriteLine(valorGenerado);
                valorInicial = valorSiguiente;
                valorSiguiente = valorGenerado;
            }

        }
    }
}
