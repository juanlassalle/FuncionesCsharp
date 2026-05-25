using System;

class Program
{
    //Se requiere un algoritmo para determinar, de N cantidades, cuántas son
    //menores o iguales a cero y cuántas mayores a cero. Resolver el ejercicio utilizando métodos como
    //crea conveniente
    static void Main(string[] args)
    {
        Ejecutar(); 
    }

    private static void Ejecutar()
    {
        int cantidadMenoresOIgualesACero = 0;
        int cantidadMayoresACero = 0;

        int nCantidades = IngresarCantidad();

        for (int i = 1; i <= nCantidades; i++)
        {
            int numeroIngresado = ObtenerNumeroAEvaluar(i);

            if (numeroIngresado > 0)
            {
                cantidadMayoresACero++;
            }
            else
            {
                cantidadMenoresOIgualesACero++;
            }
        }

        Console.WriteLine("\n========== Listado de Cantidades ===========");
        Console.WriteLine($"Cantidades mayores a cero (> 0): {cantidadMayoresACero}");
        Console.WriteLine($"Cantidades menores o iguales a cero (<= 0): {cantidadMenoresOIgualesACero}");
    }

    private static bool ValidarNCantidades(string _entrada, out int _cantidad)
    {
        bool esValido = int.TryParse(_entrada, out _cantidad) && _cantidad > 0;

        if (!esValido)
        {
            Console.WriteLine("Error. La cantidad de números a evaluar debe ser mayor a 0.");
        }
        return esValido;
    }

    private static int IngresarCantidad()
    {
        int cantidad;
        string entrada;
        bool esValido;

        do
        {
            Console.Write("¿Cuántas cantidades desea evaluar? (N): ");
            entrada = Console.ReadLine();
            esValido = ValidarNCantidades(entrada, out cantidad);
        }
        while (!esValido);

        return cantidad;
    }

    private static int ObtenerNumeroAEvaluar(int indice)
    {
        int numero;
        string entrada;
        bool esValido;

        do
        {
            Console.Write($"Ingrese el número {indice}: ");
            entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out numero);

            if (!esValido)
            {
                Console.WriteLine("Error. Debe ingresar un número entero válido.");
            }
        }
        while (!esValido);

        return numero;
    }
}
