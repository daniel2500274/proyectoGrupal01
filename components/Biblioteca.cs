using System;
using System.Collections.Generic;
using System.Linq;

namespace proyectoGrupal01.components
{
    public class Biblioteca
    {
        private List<Libro> _libros;

        public Biblioteca()
        {
            _libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            if (_libros.Any(l => l.Titulo == libro.Titulo))
            {
                throw new InvalidOperationException(" 🛑 Ya existe un libro con el mismo título.");
            }
            _libros.Add(libro);
        }

        public void PrestarLibro(string titulo, string usuario)
        {
            Libro? libro = _libros.FirstOrDefault(l => l.Titulo == titulo);
            if (libro == null)
            {
                throw new InvalidOperationException("El libro no existe en la biblioteca.");
            }
            if (!libro.Disponible)
            {
                throw new InvalidOperationException("El libro no está disponible.");
            }
            libro.Prestar(usuario);
            Console.WriteLine(libro.ToString());
        }

        public void DevolverLibro(string titulo)
        {
            Libro? libro = _libros.FirstOrDefault(l => l.Titulo == titulo);
            if (libro == null)
            {
                throw new InvalidOperationException("El libro no existe en la biblioteca.");
            }
            libro.Devolver();
            Console.WriteLine(libro.ToString());
        }

        public List<Libro> ObtenerLibrosDisponibles()
        {
            return _libros.Where(l => l.Disponible).ToList();
        }
    }
}