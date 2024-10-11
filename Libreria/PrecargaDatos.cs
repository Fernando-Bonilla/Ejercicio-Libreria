using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class PrecargaDatos
    {
        public static void Precarga() 
        {
            Libro libroUno = new Libro("Platero y yo", "Juan Ramón Jiménez", 1914);
            Libro.listaLibros.Add(libroUno);

            Libro libroDos = new Libro("El pozo y el pendulo", "El Edgar", 1823);
            Libro.listaLibros.Add(libroDos);

            Libro libroTres = new Libro("Asd", "Fernando", 1914);
            Libro.listaLibros.Add(libroTres);
        }
    }
}
