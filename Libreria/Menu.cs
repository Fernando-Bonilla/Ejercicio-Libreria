using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Menu
    {
        static bool salir = false;
        //public static string[] menu = { "1. Ingresar Libro ", "2. Listado de Libros ", "0. Salir " };
        public static void MostrarMenu()
        {
            
            while (salir == false) 
            {
                Console.WriteLine("** Menu principal, ingrese la opcion deseada **");
                Console.WriteLine();

                Console.WriteLine("1. Ingresar Libro");
                Console.WriteLine();

                Console.WriteLine("2. Listar Libros");
                Console.WriteLine();

                Console.WriteLine("3. Eliminar Libros");
                Console.WriteLine();

                Console.WriteLine("4. Filtrar Libros por anio publicacion");
                Console.WriteLine();

                Console.WriteLine("0.Salir");
                Console.WriteLine();


                int opcion;
                bool parseado = int.TryParse(Console.ReadLine(), out opcion);

                while (!parseado)
                {
                    Console.WriteLine("Por favor debe ingresar una opcion correcta");
                    parseado = int.TryParse(Console.ReadLine(), out opcion);
                }

                switch (opcion)
                {
                    case 1: Libro.AltaLibro();
                        break;

                    case 2: Libro.ListarLibros();
                        break;

                    case 3: Libro.EliminarLibro();
                        break;

                    case 4: Libro.FiltrarLibros();
                        break;

                    case 0: salir = true; 
                        break;

                    default: Console.WriteLine("Opcion incorrecta");
                        break;
                }

                LimpiarPantalla();
                
                
            }
            
        }

        public static void LimpiarPantalla()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese una tecla para continuar");
            Console.ReadKey();  
            Console.Clear();
        }
    }
}
