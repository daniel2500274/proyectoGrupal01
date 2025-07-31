using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoGrupal01.components
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public Vehiculo(string marca, string modelo, int año, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
        }
        public void Encender()
        {
            Console.WriteLine($"{Marca} {Modelo} del año {Año} ha sido encendido.");
        }
        public abstract void Conducir();
    }
}
