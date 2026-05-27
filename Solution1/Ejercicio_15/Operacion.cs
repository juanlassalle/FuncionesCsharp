using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal static class Operacion
    {
        internal static bool ValidarCantidad(string _entrada, out int _cantidad)
        {
            bool esValido = int.TryParse(_entrada, out _cantidad);

            if (!esValido || _cantidad <= 0)
            {
                Console.WriteLine("Error. Debe ingresar un número entero positivo");
                return false;
            }

            return true;
        }
        internal static int IngresarCantidad(string _valor)
        {
            int cantidad;
            string entrada;
            bool esValido;

            do
            {
                Console.Write($"Ingresar {_valor}: ");
                entrada = Console.ReadLine();

                esValido = ValidarCantidad(entrada, out cantidad);
            }
            while (!esValido);

            return cantidad;
        }
    }
}
