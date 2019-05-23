using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraConsole.Clases
{
    class Movimiento
    {
        private double monto { get; set; }
        private DateTime fecha { get; set; }
        private TipoMov tipo { get; set; }

        public Movimiento(double monto, DateTime fecha, TipoMov tipo)
        {
            this.monto = monto;
            this.fecha = fecha;
            this.tipo = tipo;

        }

    public void mostrar()
        {
            Console.WriteLine("Fecha: " + this.monto + " Fecha: " + this.fecha + " Tipo: " + this.tipo);
        }
        
    }
}
