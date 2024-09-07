using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal class Libro
    {
        public string Titulo {  get; set; }
        public string  Autor {  get; set; }
        public int? AñoDePublicacion { get; set; }
        public string? ISBN { get; set; }
        public Libro(string titulo, string autor, int? añopublicacion = null, string? isbn = null) {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AñoDePublicacion = añopublicacion;
        }
        public string obtenerInfo()
        {
            string Año = AñoDePublicacion.HasValue ? AñoDePublicacion.ToString() : "Desconocido";
            string isbn = ISBN != null ? ISBN : "Desconocido";

            return $"Titulo: {Titulo}, Autor: {Autor}, Año Publicacion: {Año},  ISBN: {isbn}";
        }
    }
}
