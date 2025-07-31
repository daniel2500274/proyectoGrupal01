using System;
using System.Collections.Generic;
using proyectoGrupal01.components;

namespace proyectoGrupal01.components
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Ejercicios...\n");
            Ejercicio01Casos();
            Ejercicio02Casos();
            Ejercicio03Casos();
            Ejercicio04Casos();
            Ejercicio05Casos();
            Ejercicio06Casos();
            Console.WriteLine("\nTodos los ejercicios han sido ejecutados.");
        }

        private static void Ejercicio01Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 01 ===");
            // EJERCICIO 01: Gestión de una biblioteca de libros
            Biblioteca miBiblioteca = new Biblioteca();
            Libro libro1 = new Libro("El Principito", "Antoine de Saint");
            Libro libroPrueba = new Libro("El Principito", "Daniel Ramirez");
            Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez");

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

            Console.WriteLine("\n******************* Libros disponibles *******************");
            var librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }

            try
            {
                Console.WriteLine("\n> Se prestará el siguiente libro: 📚");
                miBiblioteca.PrestarLibro("El Principito", "Juan Pérez");
                Console.WriteLine("Libro prestado correctamente.\n");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al prestar libro: {ex.Message}");
            }

            Console.WriteLine("******************* Libros disponibles *******************");
            librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }

            try
            {
                Console.WriteLine("\n> Se devolverá el siguiente libro: 📚");
                miBiblioteca.DevolverLibro("El Principito");
                Console.WriteLine("Libro devuelto correctamente.\n");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al devolver libro: {ex.Message}");
            }

            Console.WriteLine("******************* Libros disponibles *******************");
            librosDisponibles = miBiblioteca.ObtenerLibrosDisponibles();
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine(libro.ToString());
            }
            Console.WriteLine("=== Fin Ejercicio 01 ===\n");
        }

        private static void Ejercicio02Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 02 ===");
            // EJERCICIO 02: Usuario con validación de campos sensibles
            Usuario usuario = new Usuario("DALLIN OSORIO", "1234567890101", "contrasenia123");
            Console.WriteLine(usuario.Autenticar("contrasenia123"));
            Console.WriteLine("=== Fin Ejercicio 02 ===\n");
        }

        private static void Ejercicio03Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 03 ===");
            // EJERCICIO 03: Inventario controlado sin duplicados
            Inventario miInventario = new Inventario();

            try
            {
                miInventario.AgregarProducto("Manzanas", 50);
                miInventario.AgregarProducto("Bananas", 30);
                miInventario.AgregarProducto("Manzanas", 20);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar producto: {ex.Message}");
            }

            Console.WriteLine("\nInventario actual:");
            miInventario.MostrarInventario();

            try
            {
                miInventario.RetirarProducto("Manzanas", 30);
                miInventario.RetirarProducto("Bananas", 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al retirar producto: {ex.Message}");
            }

            Console.WriteLine("\nInventario actual después de retirar productos:");
            miInventario.MostrarInventario();
            Console.WriteLine("=== Fin Ejercicio 03 ===\n");
        }

        private static void Ejercicio04Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 04 ===");
            // EJERCICIO 04: Jerarquía de vehículos con clase abstracta
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
            Console.WriteLine("=== Fin Ejercicio 04 ===\n");
        }

        private static void Ejercicio05Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 05 ===");
            // EJERCICIO 05: Sistema escolar con personas y perfiles diferenciados
            Escuela miEscuela = new Escuela();

            // Agregar personas a la escuela
            miEscuela.AgregarPersona(new Estudiante("Juan Pérez", "Ingeniería de Software"));
            miEscuela.AgregarPersona(new Maestro("Ana Gómez", "Matemáticas"));
            miEscuela.AgregarPersona(new Estudiante("Carlos López", "Medicina"));
            miEscuela.AgregarPersona(new Maestro("Luisa Martínez", "Ciencias"));

            // Mostrar perfiles de las personas en la escuela
            Console.WriteLine("\nPerfiles de las personas en la escuela:");
            miEscuela.MostrarPerfiles();
            Console.WriteLine("=== Fin Ejercicio 05 ===\n");
        }

        private static void Ejercicio06Casos()
        {
            Console.WriteLine("\n=== Iniciando Ejercicio 06 ===");
            // EJERCICIO 06: Sistema de documentos fiscales con generación de reportes
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
            Console.WriteLine("=== Fin Ejercicio 06 ===\n");
        }
    }
}
