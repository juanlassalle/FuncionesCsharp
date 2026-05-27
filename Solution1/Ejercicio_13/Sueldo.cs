using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    //Una empresa les paga a sus empleados con base en las horas trabajadas en
    //la semana. Realice un algoritmo para determinar el sueldo semanal de N
    //trabajadores y, además, calcule cuánto pagó la empresa por los N empleados. Usando una clase
    // con los métodos que crea conveniente.
    internal class Sueldo
    {
        public decimal PagoTotalEmpresa { get; private set; }

        public Sueldo()
        {
            PagoTotalEmpresa = 0m;
        }
        private bool ValidarNTrabajadores(string _entrada, out int nTrabajadores)
        {
            bool nTrabajoresValido = int.TryParse(_entrada, out nTrabajadores) && nTrabajadores > 0;

            if (!nTrabajoresValido)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto.");
            }

            return nTrabajoresValido;
        }
        private bool ValidarHorasTrabajadas(string _entrada,out int _horasTrabajadas) 
        {
            bool horaValida = int.TryParse(_entrada, out _horasTrabajadas) && _horasTrabajadas > 0;

            if (!horaValida)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto.");
            }

            return horaValida;
        }
        private bool ValidarPagoPorHora(string _entrada, out decimal pagoPorHora)
        {
            bool pagoPorHoraValido = decimal.TryParse(_entrada, out pagoPorHora) && pagoPorHora > 0;

            if (!pagoPorHoraValido)
            {
                Console.WriteLine("Error. Valor ingresado incorrecto");
            }

            return pagoPorHoraValido;
        }
        private int IngresarNTrabajadores()
        {
            int nTrabajadores;
            string entrada;
            bool nTrabajadoresEsValido;

            do
            {
                Console.Write("Ingresar N Trabajadores: ");
                entrada = Console.ReadLine();
                nTrabajadoresEsValido = ValidarNTrabajadores(entrada, out nTrabajadores);
            }
            while (!nTrabajadoresEsValido);

            return nTrabajadores;
        }
        private int IngresarHorasTrabajadas()
        {
            int horasTrabajadas;
            string entrada;
            bool horasTrabajadasValida;
            do
            {
                Console.Write("Ingresar horas trabajadas: ");
                entrada = Console.ReadLine();
                horasTrabajadasValida = ValidarHorasTrabajadas(entrada, out horasTrabajadas);
            }
            while (!horasTrabajadasValida);

            return horasTrabajadas;
        }
        private decimal IngresarPagoPorHora()
        {
            decimal pagoPorHora;
            string entrada;
            bool pagoPorHoraValido;

            do
            {
                Console.Write("Ingresar pago por hora: ");
                entrada = Console.ReadLine();
                pagoPorHoraValido = ValidarPagoPorHora(entrada, out pagoPorHora);
            }
            while (!pagoPorHoraValido);

            return pagoPorHora;
        }
        private void Calcular()
        {
            int nTrabajadores = IngresarNTrabajadores();

            for (int i = 1; i <= nTrabajadores; i++)
            {
                Console.WriteLine($"\n--- Datos del Trabajador {i} ---");
                int horasTrabajadas = IngresarHorasTrabajadas();
                decimal pagoPorHora = IngresarPagoPorHora();

                decimal sueldoTrabajadorActual = horasTrabajadas * pagoPorHora;

                Console.WriteLine($"El sueldo semanal del trabajador {i} es: ${sueldoTrabajadorActual}");

                PagoTotalEmpresa += sueldoTrabajadorActual;

            }
            Console.WriteLine("\n========================================");
            Console.WriteLine($"El pago total por los {nTrabajadores} empleados es: ${PagoTotalEmpresa}");
            Console.WriteLine("========================================");
        }
        public void Ejecutar()
        {
            Calcular();
        }
    }
}
