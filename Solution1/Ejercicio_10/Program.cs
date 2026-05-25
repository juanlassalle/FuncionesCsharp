using System;

namespace Ejercicio_10
{
    //Una empresa tiene el registro de las horas que trabaja diariamente un
    //empleado durante la semana (seis días) y requiere determinar el total de
    //éstas, así como el sueldo que recibirá por las horas trabajadas.
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static bool ValidarPagoPorHoras(string _entrada, out decimal _pagoPorHora)
        {
            bool esvalido = decimal.TryParse(_entrada, out _pagoPorHora) && _pagoPorHora >= 0;

            if (!esvalido)
            {
                Console.WriteLine("Error. Valor ingresado no es correcto");
            }

            return esvalido;
        }
        private static decimal IngresarPagoPorHora()
        {
            decimal pagoPorHoras;
            string entrada;
            bool esValido;

            do
            {
                Console.Write("Ingresar el pago por hora: ");
                entrada = Console.ReadLine();
                esValido = ValidarPagoPorHoras(entrada, out pagoPorHoras);
            }
            while (!esValido);

            return pagoPorHoras;
        }
        private static bool ValidarHorasDiarias(string _entrada, out int _horasDiarias)
        {
            bool esValido = int.TryParse(_entrada, out _horasDiarias) && _horasDiarias >= 0;

            if (!esValido)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto");
            }
            return esValido;
        }
        private static int IngresarHorasDiarias()
        {
            int horasDiarias = 0;
            string entrada;
            bool esValido = false;

            while (!esValido)
            {
                Console.Write("Ingresar horas trabajadas por día: ");
                entrada = Console.ReadLine();
                esValido = ValidarHorasDiarias(entrada, out horasDiarias);
            }

            return horasDiarias;
        }
        private static void Ejecutar()
        {
            const int DIAS_SEMANA = 6;
            int totalHorasSemanales = 0;

            decimal pagoPorHora = IngresarPagoPorHora();
            Console.WriteLine($"\n--- Registro de horas para los {DIAS_SEMANA} días ---");

            for (int i = 1; i <= DIAS_SEMANA; i++)
            {
                Console.Write($"Ingresar horas trabajadas el Día {i}: ");
                totalHorasSemanales += IngresarHorasDiarias(); 
            }

            decimal sueldoTotal = totalHorasSemanales * pagoPorHora;

            Console.WriteLine("\n--- REPORTE SEMANAL ---");
            Console.WriteLine($"El total de horas trabajadas en la semana es: {totalHorasSemanales} hrs.");
            Console.WriteLine($"El sueldo semanal del empleado es: ${sueldoTotal}"); 
        }
    }
}
 