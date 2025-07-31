using System;
using System.Collections.Generic;

namespace proyectoGrupal01.components
{
    // Clase abstracta Persona
    public abstract class Persona
    {
        public string Nombre { get; set; }

        protected Persona(string nombre)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }
 
        public abstract void MostrarPerfil();
    }

    // Clase estudiante
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, string carrera) : base(nombre)
        {
            Carrera = carrera ?? throw new ArgumentNullException(nameof(carrera));
        }

        public override void MostrarPerfil()
        {
            Console.WriteLine($"Estudiante: {Nombre}, Carrera: {Carrera}");
        }
    }

    // Clase Maestro
    public class Maestro : Persona
    {
        public string Especialidad { get; set; }

        public Maestro(string nombre, string especialidad) : base(nombre)
        {
            Especialidad = especialidad ?? throw new ArgumentNullException(nameof(especialidad));
        }

        public override void MostrarPerfil()
        {
            Console.WriteLine($"Maestro: {Nombre}, Especialidad: {Especialidad}");
        }
    }

    // Clase Escuela
    public class Escuela
    {
        private List<Persona> personas;

        public Escuela()
        {
            personas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            if (persona == null)
                throw new ArgumentNullException(nameof(persona), "La persona no puede ser nula.");
            personas.Add(persona);
        }

        public void MostrarPerfiles()
        {
            foreach (var persona in personas)
            {
                persona.MostrarPerfil();
            }
        }
    }
}