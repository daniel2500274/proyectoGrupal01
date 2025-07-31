using System;
using proyectoGrupal01.components;

namespace proyectoGrupal01.components
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
            
            //EJERCIO #2 : Usuario con validación de campos sensibles
            // /*
            //     Aplicar reglas de validación dentro de propiedades y proteger datos privados.
            //     Crea una clase Usuario con los siguientes atributos:
            //     Nombre (público)
            //     DPI (debe validarse: exactamente 13 dígitos)
            //     Contraseña (mínimo 6 caracteres; solo se puede asignar, no leer directamente)
            //     Además, incluye un método Autenticar(string input) que verifique si la contraseña ingresada
            //     coincide. La clase debe garantizar que ningún dato sensible sea accesible directamente, sino
            //     solo mediante propiedades o métodos controlados.
            //  */
            Usuario usuario = new Usuario("DALLIN OSORIO", "1234567890101", "contrasenia123");
            Console.WriteLine(usuario.Autenticar("contrasenia123"));
            
            //EJERCICIO 03:
            
            
            //EJERCICIO #4: Jerarquía de vehículos con clase abstracta
            /*
                Utilizar clases abstractas para definir comportamientos comunes en tipos de objetos
                relacionados.

                Crea una clase abstracta Vehiculo con métodos Encender() y Conducir().
                Luego, implementa dos clases concretas: Carro y Motocicleta.
                Cada tipo debe definir un comportamiento distinto al conducir.
                Crea una lista de Vehiculo y recórrela para probar el comportamiento polimórfico.
             */

            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Carro("Honda", "Civic", 2008, "Negro"),
                new Motocicleta("Honda", "Navi", 2025, "Rosada"),
                new Carro("Toyota", "Corolla", 2020, "Blanco"),
                new Carro("Toyota", "Yaris", 2020, "Rojo")
            };

            foreach (var vehiculo in vehiculos)
            {
                vehiculo.Encender();
                vehiculo.Conducir();
            }
            
            //EJERCICIO 05 :

            //EJERCICIO #6: Sistema de documentos fiscales con generación de reportes
            /*
                Aplicar abstracción y polimorfismo en un contexto profesional.
                Define una clase abstracta DocumentoFiscal con un método GenerarPDF() y atributo
                Numero.
                Luego, crea subclases: Factura, NotaCredito, NotaDebito, cada una con una implementación
                propia del método.
                Crea una clase GestorDocumentos que reciba una lista de documentos y ejecute
                GenerarPDF() sin importar su tipo específico.
             */
            List<DocumentoFiscal> documentos = new List<DocumentoFiscal>
            {
                new Factura(145451215, "Dallin Osorio", 150.75m),
                new Factura(215555525, "Daniel Ramirez", 200.00m),
                new NotaCredito(315555525, "Dallin Osorio", 150.75m),
                new NotaCredito(431555552, "Daniel Ramirez", 75.00m),
                new NotaDebito(531555552, "Dallin Osorio", 200.00m),
                new NotaDebito(631555552, "Daniel Ramirez", 200.00m),
            };

            foreach (var documento in documentos)
            {
                documento.GenerarPDF();
            }
            
        }
    }
}
