using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    //Una compañía fabrica focos de colores (verdes, blancos y rojos). Se
    //desea contabilizar, de un lote de N focos, el número de focos de cada
    //color que hay en existencia. Resolver el ejercicio Con 2 clases y los 
    //métodos que crea necesarios.
    internal class Focos
    {
        public int CantidadVerde { get;private set; }
        public int CantidadBlanco { get;private set; }
        public int CantidadRojo { get;private set; }

        public Focos()
        {
            CantidadVerde = 0;
            CantidadBlanco = 0;
            CantidadRojo = 0;
        }

        private void CalcularCantidades()
        {
            string focos = "cantidad de focos";
            int nFocos = Operacion.IngresarCantidad(focos);

            for (int i = 1; i <= nFocos; i++)
            {
                SeleccionarFocos(i, nFocos);
                Console.WriteLine();
                Console.WriteLine("Registrado correctamente");
            }
        }
        private void SeleccionarFocos(int _contador, int _nFocos)
        {
            string tipos = "1. VERDE || 2. BlANCO || 3. ROJO";
            int tipo;
            do
            {
                Console.WriteLine($"\nProcesando foco numero {_contador} de {_nFocos}");
                Console.WriteLine("Seleccionar el color: ");
                //Console.WriteLine("1. VERDE || 2. BlANCO || 3. ROJO");
                tipo = Operacion.IngresarCantidad(tipos);

                if (tipo < 1 || tipo > 3)
                {
                    Console.WriteLine("Error. Intente de nuevo");
                }
            }
            while (tipo < 1 || tipo > 3);


            switch (tipo)
            {
                case 1:
                    CantidadVerde++;
                    break;
                case 2:
                    CantidadBlanco++;
                    break;
                case 3:
                    CantidadRojo++;
                    break;
            }
        }
        private void Imprimir()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("RESUMEN DE EXISTENCIAS");
            Console.WriteLine("==============================================");
            Console.WriteLine($"FOCOS VERDES {CantidadVerde}");
            Console.WriteLine($"FOCOS BLANCOS {CantidadBlanco}");
            Console.WriteLine($"FOCOS ROJOS {CantidadRojo}");
        }

        public void Ejecutar()
        {
            CalcularCantidades();
            Imprimir();
        }
    }
}
