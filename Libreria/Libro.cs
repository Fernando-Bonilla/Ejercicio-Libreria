using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Libro
    {
        public static List<Libro> listaLibros = new List<Libro>();
        static int idCounter = 0;

        #region Propiedades
        public int ID { get; private set; }
        string Titulo { get; set; }
        string Autor {  get; set; }
        int AnioPublicacion { get; set; }
        #endregion Propiedades

        #region Constructores
        public Libro(string titulo, string autor, int anio)
        {
            ID = idCounter++;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anio;           
            
        }
        #endregion Constructores

        #region Metodos
        public static void AltaLibro()
        {
            Console.WriteLine("Ingrese el Titulo del libro: ");
            string ?nombreLibro = Console.ReadLine();

            while(nombreLibro.Length == 0)
            {
                Console.WriteLine("Ingrese el Titulo del libro: ");
                nombreLibro = Console.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Ingrese el nombre del autor");
            string ?nombreAutor = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Ingrese el Año de publicacion");            
            bool succes = int.TryParse(Console.ReadLine(), out int number);
            //int year = int.TryParse(Console.ReadLine(), out number);
            while(succes == false || number < 1000)
            {
                Console.WriteLine("Debe ingresar un año de 4 digitos: ");
                succes = int.TryParse(Console.ReadLine(), out number);
            }

            Libro newLibro = new Libro (nombreLibro, nombreAutor, number);

            listaLibros.Add (newLibro);

            Console.WriteLine("");
            Console.WriteLine("Libro agregado");

        }

        public static void ListarLibros()
        {

            if(listaLibros.Count == 0)
            {
                Console.WriteLine("No existen libros para listar");
            }
            else
            {
                foreach (Libro libro in listaLibros)
                {

                    Console.WriteLine($"ID: {libro.ID}, Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año Publicacion: {libro.AnioPublicacion}");
                }
            }
            Console.WriteLine("");           
            
        }

        public static void EliminarLibro()
        {
            Console.WriteLine("Ingrese el ID del libro a eliminar");
            int id;
            bool success = int.TryParse(Console.ReadLine(), out id);

            while(success == false)
            {
                Console.WriteLine("Pro favor, debe ingresar un ID valido");
                success = int.TryParse(Console.ReadLine(), out id);
            }

            List<Libro> librosAEliminar = new List<Libro>();

            foreach(Libro libro in listaLibros)
            {
                if(libro.ID == id)
                {
                    librosAEliminar.Add(libro);
                }
            }

            foreach (Libro libro in librosAEliminar)
            {
                if(libro.ID == id)
                {
                    Console.WriteLine($"Libro {libro.Titulo} eliminado");
                    listaLibros.Remove(libro);
                }else
                {
                    Console.WriteLine("No existen libros con ese ID");
                }
            }            

        }

        public static void FiltrarLibros()
        {
            Console.WriteLine("Ingrese un año");

            int opcionIngresada;
            bool success = int.TryParse(Console.ReadLine(), out opcionIngresada);

            while (success == false || opcionIngresada < 1000) 
            {
                Console.WriteLine("Por favor debe ingresar un año valido o un año de 4 difitos");
                success = int.TryParse(Console.ReadLine(), out opcionIngresada);
            }

            List<Libro> librosMatcheados = new List<Libro>();

            foreach(Libro libro in listaLibros)
            {
                if(libro.AnioPublicacion == opcionIngresada)
                {
                    librosMatcheados.Add(libro);
                }                
            }

            foreach (Libro libro in librosMatcheados)
            {
                if(librosMatcheados.Count == 0)
                {
                    Console.WriteLine("No existen libros publicados en ese año");
                }else
                {
                    Console.WriteLine($"ID: {libro.ID}, Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año Publicacion: {libro.AnioPublicacion}");
                }
            }

        }
        

        #endregion Metodos

    }
}
