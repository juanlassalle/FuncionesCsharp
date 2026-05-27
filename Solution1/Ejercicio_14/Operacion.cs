using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    //La cadena de tiendas de autoservicio "El mandilón" cuenta con sucursales
    //en C ciudades diferentes de la República, en cada ciudad cuenta con T
    //tiendas y cada tienda cuenta con N empleados, asimismo, cada una registra
    //lo que vende de manera individual cada empleado, cuánto fue lo que
    //vendió cada tienda, cuánto se vendió en cada ciudad y cuánto recaudó la
    //cadena en un solo día. Resolver el ejercio con un clase para validar datos
    //y otra para calcular las ventas.
    internal static class Operacion
    {

        internal static bool ValidarNCantidades(string _entrada,out int _nCantidad)
        {
            bool esValido = int.TryParse(_entrada, out _nCantidad) && _nCantidad > 0;

            if (!esValido)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto"); ;
            }

            return esValido;
        }
        internal static int IngresarNCantidades(string _valor)
        {
            int nCantidad;
            string entrada;
            bool esValido;

            do
            {
                Console.Write($"Ingresar {_valor}: ");
                entrada = Console.ReadLine();
                esValido = ValidarNCantidades(entrada, out nCantidad);
            }
            while (!esValido);

            return nCantidad;
        }
        internal static bool ValidarVenta(string _entrada, out decimal _venta)
        {
            bool esValido = decimal.TryParse(_entrada, out _venta);

            if (!esValido)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto");
            }

            return esValido && _venta > 0;
        }
        internal static decimal IngresarVenta()
        {
            decimal venta;
            string entrada;
            bool esValido;

            do
            {
                Console.Write("Ingresar venta: ");
                entrada = Console.ReadLine();

                esValido = ValidarVenta(entrada, out venta);
            }
            while (!esValido);

            return venta;
        }

    }
}
