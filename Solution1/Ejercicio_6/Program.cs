using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        //Se requiere un algoritmo para determinar cuánto ahorrará una persona
        //en un año, si al final de cada mes deposita variables cantidades de dinero;
        //además, se requiere saber cuánto lleva ahorrado cada mes. Resolver el ejercicio usando los
        //métodos que considere necesarios.  
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            Console.WriteLine("--- Control de Ahorros Mensuales ---\n");

            decimal resultadoFinal = CalcularAhorroAnual();

            Console.WriteLine("\n=========================================");
            Console.WriteLine($"El total ahorrado al final del año es: ${resultadoFinal}");
            Console.WriteLine("=========================================");
        }
        private static bool ValidarDesposito(string _entrada, out decimal _deposito)
        {
            bool esDeposito = decimal.TryParse(_entrada, out _deposito) && _deposito >= 0;

            if (!esDeposito)
            {
                Console.WriteLine("Error. Valor ingresado no válido");
            }
            return esDeposito;
        }
        private static decimal IngresarDepositoPorMes(int mes)
        {
            decimal deposito;
            string entrada;
            bool esValido;

            do
            {
                Console.Write($"Ingresar deposito del mes {mes}: ");
                entrada = Console.ReadLine();
                esValido = ValidarDesposito(entrada, out deposito);
            }
            while (!esValido);

            return deposito;
        }
        private static decimal CalcularAhorroAnual()
        {
            decimal totalAhorros = 0m;
            const int meses = 12;

            for (int i = 1; i <= meses; i++)
            {
                decimal depositoMensual = IngresarDepositoPorMes(i);
                totalAhorros = totalAhorros + depositoMensual;
                Console.WriteLine($"Ahorro acumulado hasta el mes {i}: ${totalAhorros}");
            }

            return totalAhorros;
        }
    }
}
