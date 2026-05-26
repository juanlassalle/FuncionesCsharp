using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    //Una persona adquirió un producto para pagar en 20 meses. El primer mes
    //pagó $10, el segundo $20, el tercero $40 y así sucesivamente. Realice un
    //algoritmo para determinar cuánto debe pagar mensualmente y el total de
    //lo que pagó después de los 10 meses. Resolver el ejercicio con una clase
    //y los métodos que sean necesarios.
    internal class Compra
    {
        private const int MESES = 10;
        public decimal PagoTotal { get; private set; }

        public Compra()
        {
            PagoTotal = 0m;
        }

        private void CalcularPagos()
        {
            decimal pagoMensual = 10m;
            Console.WriteLine("===========Cronogramas de Pagos==========");
            for (int i = 1; i <= MESES ; i++)
            {
                Console.WriteLine($"El pago del mes {i} es ${pagoMensual}");
                
                PagoTotal = PagoTotal + pagoMensual;

                pagoMensual = pagoMensual * 2;
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"El pago total después de los {MESES} meses es: ${PagoTotal}");
            Console.WriteLine("------------------------------------------------");
        }
        public void Ejecutar()
        {
            CalcularPagos();
        }
    }
}
