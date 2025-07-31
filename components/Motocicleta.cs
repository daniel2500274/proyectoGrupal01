using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoGrupal01.components
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo, int año, string color): base(marca, modelo, año, color) { }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo la motocicleta {Marca} {Modelo} del año {Año} de color {Color} por la cuidad y se estrelló.");
        }
    }
}
