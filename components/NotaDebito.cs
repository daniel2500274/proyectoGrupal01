using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoGrupal01.components
{
    public class NotaDebito : DocumentoFiscal
    {
        public int Numero { get; set; }

        public string Cliente { get; set; }
        public decimal Monto { get; set; }

        public NotaDebito(int numero, string cliente, decimal monto)
        {
            Numero = numero;
            Cliente = cliente;
            Monto = monto;
        }
        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de la nota de debito {Numero} para el cliente {Cliente} por un monto de Q.{Monto}");
        }
    }
}
