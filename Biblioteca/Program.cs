using Biblioteca.Clases;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiBiblioteca miBiblioteca = new MiBiblioteca();
            int opcion;
            Libro unMundoFeliz = new Libro("Un mundo feliz", "Aldous Huxley");
            miBiblioteca.AgregarLibro(unMundoFeliz);
            miBiblioteca.AgregarLibro("Orgullo y prejuicio", "Jane Austen");
            do
            {
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Introduce los siguientes requicitos");
                        Agregar(miBiblioteca);

                        break;
                    case 2:
                        Console.Clear();
                        Buscar(miBiblioteca);
                        break;
                    case 3:
                        Console.Clear();
                        Listar(miBiblioteca);
                        break;
                    case 4:
                        Console.Clear();
                        Eliminar(miBiblioteca);
                        break;
                    case 5:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 5);

        }
        public static int LeerOpcion()
        {
            int opcion = 0;
            bool opcionValida = false;


            Console.WriteLine("\nBienvenido al sistema de Gestion de la Biblioteca");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Buscar libro por Autor");
            Console.WriteLine("3. Listar Libros");
            Console.WriteLine("4. Eliminar Libro");
            Console.WriteLine("5. Salir");

            string opcionReadLine = Console.ReadLine();

            if (int.TryParse(opcionReadLine, out opcion))
            {
                opcionValida = true;
            }
            else
            {
                Console.WriteLine("La opción debe ser un número entero");
            }


            return opcion;
        }
        public static void Listar(MiBiblioteca biblioteca)
        {
            biblioteca.ListarLibros();
        }
        public static void Buscar(MiBiblioteca biblioteca)
        {
            Console.WriteLine("Introduce el nombre del autor:");
            string autor = Console.ReadLine();
            Console.Clear();
            biblioteca.BuscarLibro(autor);
        }

        public static void Eliminar(MiBiblioteca biblioteca)
        {
            Console.WriteLine("Introduce el nombre del libro:");
            string titulo = Console.ReadLine();
            Console.Clear();
            biblioteca.EliminarLibro(titulo);
        }

        public static void Agregar(MiBiblioteca biblioteca)
        {
            Console.WriteLine("Introduce el título del libro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Introduce el autor del libro:");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduce el año de publicación (opcional, presiona Enter para omitir):");
            string anioInput = Console.ReadLine();
            int? anioPublicacion = null;
            if (int.TryParse(anioInput, out int anio))
            {
                anioPublicacion = anio;
            }

            Console.WriteLine("Introduce el ISBN (opcional, presiona Enter para omitir):");
            string isbn = Console.ReadLine();

            biblioteca.AgregarLibro(titulo, autor, anioPublicacion, string.IsNullOrWhiteSpace(isbn) ? null : isbn);
            Console.WriteLine("Libro agregado con éxito.");
        }

    }
}
