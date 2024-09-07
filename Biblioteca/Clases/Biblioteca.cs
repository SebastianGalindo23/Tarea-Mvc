using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    
    class MiBiblioteca
    {
        private List<Libro> Libros;

        public MiBiblioteca()
        {
            Libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"Libro {libro.Titulo} agregado a la biblioteca");
        }
        public void AgregarLibro(string titulo, string autor, int? anioPublicacion = null, string? isbn = null)
        {
            if (anioPublicacion.HasValue && isbn != null)
            {
                Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion, isbn);
                Libros.Add(nuevoLibro);
            }
            else if (anioPublicacion.HasValue)
            {
                Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion);
                Libros.Add(nuevoLibro);
            }
            else if (isbn != null)
            {
                Libro nuevoLibro = new Libro(titulo, autor, isbn: isbn);
                Libros.Add(nuevoLibro);
            }
            else
            {
                Libro nuevoLibro = new Libro(titulo, autor);
                Libros.Add(nuevoLibro);
            }
        }
        public void ListarLibros()
        {
            Console.WriteLine("Libros disponibles en la biblioteca:");
            foreach (Libro libro in Libros)
            {
                Console.WriteLine(libro.obtenerInfo());
            }
        }
        public void EliminarLibro(string titulo) {
            bool libroEncontrado = false;

            for (int i = 0; i < Libros.Count; i++)
            {
                if (titulo == Libros[i].Titulo)
                {
                    Libros.Remove(Libros[i]);
                    Console.WriteLine($"Se ha eliminado el libro '{titulo}'");
                    ListarLibros();
                    libroEncontrado = true;
                    break;
                }
            }

            if (!libroEncontrado)
            {
                Console.WriteLine($"No existe un libro con el nombre '{titulo}' en la biblioteca");
            }
        }
        public void BuscarLibro(string autor) {
            bool TieneLibros = false;
            for (int i = 0; i < Libros.Count; i++)
            {
                if (autor == Libros[i].Autor)
                {
                    TieneLibros = true;
                    Console.WriteLine($"Libro: {Libros[i].Titulo}");
                    
                }
            }

            if (!TieneLibros)
            {
                Console.WriteLine($"No existen libros excritos por {autor}");
            }

        }

       


    }
}