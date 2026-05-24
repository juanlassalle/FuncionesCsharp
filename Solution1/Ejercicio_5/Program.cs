using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    //Se requiere un algoritmo para obtener la estatura promedio de un grupo
    //de personas, cuyo número de miembros se desconoce, el ciclo debe
    //efectuarse siempre y cuando se tenga una estatura registrada. Resolver el ejercicio
    //usando los métodos que considere necesarios.
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Ejecutar()
        {
            double sumaEstaturas = 0;
            int cantidadPersonas = 0;

            while (true)
            {
                double estatura = ObtenerEstatura();

                if (estatura == -1)
                {
                    break;
                }
                else
                {
                    sumaEstaturas = SumarEstaturas(sumaEstaturas,estatura);
                    cantidadPersonas++;
                }
            }
            ImprimirPromedio(sumaEstaturas, cantidadPersonas);
        }
        private static bool ValidarEstatura(string entrada,out double _estatura)
        {
            bool estaturaValida = double.TryParse(entrada, out _estatura) && _estatura > 0;

            if (!estaturaValida)
            {
                Console.WriteLine("Error. Datos ingresado no válido");
            }

            return estaturaValida;
        }
        private static double ObtenerEstatura()
        {
            double estatura;
            string entrada;
            bool esValido;

            do
            {
                Console.Write("Ingresar altura (o 0 para finalizar): ");
                entrada = Console.ReadLine();

                if (entrada == "0")
                {
                    return -1;
                }
                esValido = ValidarEstatura(entrada, out estatura);
            }
            while (!esValido);

            return estatura;
        }

        private static double SumarEstaturas(double _suma, double _estatura)
        {
            return _suma + _estatura;
        }
        private static void ImprimirPromedio(double _sumaEstatura, int _cantidadPersonas)
        {
            if (_cantidadPersonas > 0)
            {
                double promedio = _sumaEstatura / _cantidadPersonas;
                Console.WriteLine($"Se registraron {_cantidadPersonas} personas.");
                Console.WriteLine($"La estatura promedio es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se registraron estaturas válidas.");
            }
        }
       
    }
}
