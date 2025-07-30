using System;
using proyectoGrupal01.components;

namespace proyectoGrupal01
{
    class Program
    {
        public static void Main(string[] args)
        {
            //EJERCICIO 01
            
            Biblioteca miBiblioteca = new Biblioteca();
            // creamos nuevos libros
            Libro libro1 = new Libro("El Principito", "Antoine de Saint");
            Libro libroPrueba = new Libro("El Principito", "Daniel Ramirez");
            Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez");

            // Agregar libros a la biblioteca
            try
            {
                miBiblioteca.AgregarLibro(libro1);
                miBiblioteca.AgregarLibro(libro2);
                miBiblioteca.AgregarLibro(libroPrueba);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al agregar libro: {ex.Message}");
            }

            // Mostrar los libros disponibles
            Console.WriteLine("*******************  Libros disponibles  *******************");
            var librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }

            // Prestar un libro
            Console.WriteLine("> Se prestará el siguiente libro: 📚");
            try
            {
                miBiblioteca.PrestarLibro("El Principito", "Juan Pérez");
                Console.WriteLine("Libro prestado correctamente. \n");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al prestar libro: {ex.Message}");
            }

            // Mostrar los libros disponibles después del préstamo
            Console.WriteLine("*******************  Libros disponibles  *******************");
            librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }

            // Devolver un libro
            Console.WriteLine("> Se devolverá el siguiente libro: 📚");
            try
            {
                miBiblioteca.DevolverLibro("El Principito");
                Console.WriteLine("Libro devuelto correctamente. \n");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al devolver libro: {ex.Message}");
            }

            // Mostrar los libros disponibles después de la devolución
            Console.WriteLine("*******************  Libros disponibles  *******************");
            librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }
            
            // EJERCICIO 02
            
            // EJERCICIO 03
            
        }
    }
}
