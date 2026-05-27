using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Tienda
    {
        private void Calcular()
        {
            decimal sumaTotal = 0m;
            string ciudad = "Ciudad";
            int nCiudades = Operacion.IngresarNCantidades(ciudad);

            for (int i = 1; i <= nCiudades; i++)
            {
                decimal sumaCiudad = 0m; // Se reinicia para cada ciudad nueva
                string tienda = "Tienda";
                Console.WriteLine($"\n=============================");
                Console.WriteLine($"=== CIUDAD {i} ===");
                Console.WriteLine($"=============================");
                int nTiendas = Operacion.IngresarNCantidades(tienda);

                for (int j = 1; j <= nTiendas; j++)
                {
                    decimal sumaTienda = 0m;
                    string empleado = "Empleado";
                    Console.WriteLine($"===Tiendas {j}");
                    int nEmpleados = Operacion.IngresarNCantidades(empleado);

                    for (int k = 1; k <= nEmpleados; k++)
                    {
                        Console.Write($"Empleado {k} -> ");
                        decimal venta = Operacion.IngresarVenta();

                        sumaTienda = sumaTienda + venta;
                    }

                    Console.WriteLine($"-> Venta total Tienda {j}: ${sumaTienda}");
                    sumaCiudad = sumaCiudad + sumaTienda;
                }
                Console.WriteLine($"\n=> VENTA TOTAL CIUDAD {i}: ${sumaCiudad}");
                sumaTotal = sumaTotal + sumaCiudad;
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine($"LA RECAUDACIÓN TOTAL DE LA CADENA ES: ${sumaTotal}");
            Console.WriteLine("==========================================");
        }

        public void Ejecutar()
        {
            Calcular();
        }
    }
}
