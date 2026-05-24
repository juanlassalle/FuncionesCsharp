using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        //Se requiere un algoritmo para obtener la edad promedio de un grupo de N
        //alumnos. El valor de N se ingresará por teclado. Usar Métodos para resolver el
        //ejercicio.
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            int cantidadAlumnos = ObtenerCantidadAlumnos();
            int sumaEdades = 0;
            for (int i = 1; i <= cantidadAlumnos; i++)
            {
                sumaEdades = sumaEdades + ObtenerEdadAlumno();
            }
            ImprimirPromedio(sumaEdades, cantidadAlumnos);
        }
        private static bool ValidarCantidadAlumnos(string _entrada, out int _cantidad)
        {
            bool esNumero = int.TryParse(_entrada, out _cantidad) && _cantidad > 0;

            if (!esNumero)
            {
                Console.WriteLine("Error. Valor ingresado no es valido");
            }

            return esNumero;
        }
        private static int ObtenerCantidadAlumnos()
        {
            int cantidadAlumnos;
            string entrada;
            bool esValido;

            do
            {
                Console.Write("Ingresar la cantidad de alumnos: ");
                entrada = Console.ReadLine();
                esValido = ValidarCantidadAlumnos(entrada, out cantidadAlumnos);
            }
            while (!esValido);

            return cantidadAlumnos;
        }
        private static bool ValidarEdad(string entrada, out int _edad)
        {
            bool esEdadValida = int.TryParse(entrada, out _edad) && _edad > 0;

            if (!esEdadValida)
            {
                Console.WriteLine("Error. Valor invalido");
            }

            return esEdadValida;
        }
        private static int ObtenerEdadAlumno()
        {
            int edad;
            string entrada;
            bool esValido;
            do
            {
                Console.Write("Ingresar la edad del alumno: ");
                entrada = Console.ReadLine();
                esValido = ValidarEdad(entrada, out edad);
            }
            while (!esValido);
            return edad;
        }
        private static void ImprimirPromedio(int _sumaEdades, int _cantidadAlumnos)
        {
            double promedio = (double)_sumaEdades / _cantidadAlumnos;
            Console.WriteLine($"La edad promedio del grupo de alumnos es {promedio} ");
        } 
    }
}
