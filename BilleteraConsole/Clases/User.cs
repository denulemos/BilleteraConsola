using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraConsole.Clases
{
    class User
    {
        private string alias { get; set; }
        private string nombre{ get; set; }
        private string apellido { get; set; }
        private string mail { get; set; }
        private double saldo { get; set; }
        private string password { get; set; }
        private ArrayList movimientos;

        public User(string alias, string nombre, string apellido, string mail, double saldo, string password)
        {
            this.alias = alias;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.saldo = saldo;
            this.password = password;
            this.movimientos = new ArrayList();
        }

        private bool validarMonto(double monto)
        {
            return (monto >= 0);
        }
        public void addMovimiento (double monto, TipoMov tipo)
        {
            var fecha = DateTime.Now; //Toma la fecha actual
            if (!validarMonto(monto))
            {
                Console.WriteLine("Monto no valido");
                
            }
            else
            {
            Movimiento movimiento = new Movimiento(monto, fecha, tipo);
                        movimientos.Add(movimiento);
                        Console.WriteLine("Movimiento agregado OK");
            }
            
            
        }

        public void verMovimientos()
        {
            foreach (Movimiento m in movimientos)
            {
                m.mostrar();
            }
        }

        

        
    }
}
