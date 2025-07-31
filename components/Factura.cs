using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoGrupal01.components
{
    public class Factura : DocumentoFiscal
    {
        private  int Numero { get; set; }
        private string Cliente { get; set; }
        private decimal Monto { get; set; }
        public Factura(int numero, string cliente, decimal monto)
        {
            Numero = numero;
            Cliente = cliente;
            Monto = monto;
        }
        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de la factura {Numero} para el cliente {Cliente} por un monto de Q.{Monto}.");
        }
    }
}
