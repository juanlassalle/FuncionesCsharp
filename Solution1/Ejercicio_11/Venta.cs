using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    //Un empleado de la tienda "Tiki Taka" realiza N ventas durante el día, se requiere
    //saber cuántas de ellas fueron mayores a $1000, cuántas fueron mayores
    //a $500 pero menores o iguales a $1000, y cuántas fueron menores o
    //iguales a $500. Además, se requiere saber el monto de lo vendido en cada
    //categoría y de forma global.
    internal class Venta
    {
        private int contarA;
        private int contarB;
        private int contarC;
        public decimal MontoCategoriaA { get; private set; }
        public decimal MontoCategoriaB { get; private set; }
        public decimal MontoCategoriaC { get; private set; }
        public decimal TotalMontoCategoria { get; private set; }

        public Venta()
        {
            contarA = 0;
            contarB = 0;
            contarC = 0;
            MontoCategoriaA = 0;
            MontoCategoriaB = 0;
            MontoCategoriaC = 0;
            TotalMontoCategoria = 0;
        }

        private bool ValidarCantidadVentas(string _entrada, out int _cantidadVentas)
        {
            bool esValido = int.TryParse(_entrada, out _cantidadVentas) && _cantidadVentas > 0;

            if (!esValido)
            {
                Console.WriteLine("Error. Valor ingresado no es correcto");
            }
            return esValido;
        }
        private int IngresaCantidadVentas()
        {
            int cantidad;
            string entrada;
            bool esValido;

            do
            {
                Console.WriteLine("Ingresar cantidad N ventas: ");
                entrada = Console.ReadLine();
                esValido = ValidarCantidadVentas(entrada,out cantidad);

            }
            while (!esValido);

            return cantidad;
        }
        private bool ValidadarVentas(string _entrada,out decimal _ventas)
        {
            bool esvalido = decimal.TryParse(_entrada, out _ventas) && _ventas > 0;

            if (!esvalido)
            {
                Console.WriteLine("Error. Valor incorrecto");
            }

            return esvalido;
        }
        private decimal IngresarVenta()
        {
            decimal venta;
            string entrada;
            bool esvalido;

            do
            {
                Console.Write("Ingresar venta: ");
                entrada = Console.ReadLine();
                esvalido = ValidadarVentas(entrada, out venta);
            }
            while (!esvalido);

            return venta;
        }
        //private void InicializarValores()
        //{
        //    // Reiniciamos todo por si la clase se ejecuta más de una vez
        //    contarA = contarB = contarC = 0;
        //    MontoCategoriaA = MontoCategoriaB = MontoCategoriaC = TotalMontoCategoria = 0;
        //}
        private void OperacionVenta()
        {
            //InicializarValores();
            int nCantidades = IngresaCantidadVentas();

            for (int i = 1; i <= nCantidades; i++)
            {
                decimal venta = IngresarVenta();

                if (venta > 1000)
                {
                    contarA = contarA + 1;
                    MontoCategoriaA = MontoCategoriaA + venta;
                }
                else if(venta > 500)
                {
                    contarB = contarB + 1;
                    MontoCategoriaB = MontoCategoriaB + venta;
                }
                else if(venta <= 500)
                {
                    contarC = contarC + 1;
                    MontoCategoriaC = MontoCategoriaC + venta;
                }
            }
            TotalMontoCategoria = MontoCategoriaA + MontoCategoriaB + MontoCategoriaC;
        }
        private void ImprimirReporte()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("           REPORTE DE VENTAS             ");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Categoría A (>1000):       {contarA} ventas. Total: ${MontoCategoriaA}");
            Console.WriteLine($"Categoría B (501 - 1000):  {contarB} ventas. Total: ${MontoCategoriaB}");
            Console.WriteLine($"Categoría C (<=500):       {contarC} ventas. Total: ${MontoCategoriaC}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Monto Global Vendido:               Total: ${TotalMontoCategoria}");
            Console.WriteLine("=========================================");
        }
        public void Ejecutar()
        {
            OperacionVenta();
            ImprimirReporte();
        }
    }
}
